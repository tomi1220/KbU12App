using PbaU12Tools.TournamentData;
using PbaU12Tools.Venue;

namespace PbaU12Tools.Bracket
{
    public class BracketDataGenerator
    {
        #region Enum
        #endregion

        #region 定数
        #endregion

        #region フィールド
        /// <summary>
        /// 不要な枠を除いたシード番号の配列
        /// </summary>
        //private PartInfo _allDataInfo = new();
        #endregion

        #region コンストラクタ

        public BracketDataGenerator(Category category, int numOfTeams, int numOfSuperSeed)
        {
            BracketData.Category = category;
            BracketData.NumberOfTeams = numOfTeams;
            BracketData.NumberOfSuperSeed = numOfSuperSeed;

            BracketData.PureSeedArray = new int[BracketData.NumberOfTeams];
        }
        #endregion

        #region プロパティ
        public TournamentData.TournamentData? _tournamentData { get; set; }
        public BracketData BracketData { get; set; } = new();
        #endregion

        #region メソッド
        public void Create()
        {
            // 全体を一つのパートに見立てて作業用の枠を作りシード番号を埋める
            BracketData.AllDataInfo!.NumOfTeams = BracketData.NumberOfTeams;
            fillSeedNumber(BracketData.AllDataInfo, BracketData.NumberOfTeams);

            if (BracketData.NumberOfSuperSeed != 0)
            {
                int addRound = round(BracketData.NumberOfSuperSeed, out _);
                BracketData.AllDataInfo.Round += addRound - 1;
            }

            // 不要な枠を除いたシード番号の配列を作る
            BracketData.PureSeedArray = new int[BracketData.NumberOfTeams];
            int tIdx = 0;
            for (int i = 0; i < BracketData.AllDataInfo.FullFrames / 2; i++)
            {
               if (BracketData.AllDataInfo.FirstRoundData[i].Slots[0] != 0)
                {
                    BracketData.PureSeedArray[tIdx++] = BracketData.AllDataInfo.FirstRoundData[i].Slots[0];
                }
                if (BracketData.AllDataInfo.FirstRoundData[i].Slots[1] != 0)
                {
                    BracketData.PureSeedArray[tIdx++] = BracketData.AllDataInfo.FirstRoundData[i].Slots[1];
                }
            }

            if (BracketData.NumberOfSuperSeed == 0)
            {
                BracketData.PartInfos.Add(BracketData.AllDataInfo);
            }
            else
            {
                // スーパーシード毎にパート分けしチーム数を決める
                int[] numOfTeamsPerPart = new int[BracketData.NumberOfSuperSeed];
                int partIdx = 0;
                int teams = 1;
                for (int i = 1; i < BracketData.NumberOfTeams; i++)
                {
                    teams++;
                    if (BracketData.PureSeedArray[i] <= BracketData.NumberOfSuperSeed * 2)
                    {
                        numOfTeamsPerPart[partIdx++] = teams;
                        teams = 1;
                        i++;
                    }
                }
                // スーパーシードのパート毎に、シード番号を埋める
                BracketData.PartInfos = [];
                for (int i = 0; i < BracketData.NumberOfSuperSeed; i++)
                {
                    BracketData.PartInfo partDataInfo = new()
                    {
                        PartNumber = i + 1,
                        NumOfTeams = numOfTeamsPerPart[i]
                    };
                    fillSeedNumber(partDataInfo!, partDataInfo.NumOfTeams - 1);

                    BracketData.PartInfos.Add(partDataInfo);
                }
            }
        }
        #endregion

        #region ローカル・メソッド
        /// <summary>
        /// 決勝までの回戦数を求める
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="element">out int</param>
        /// <returns></returns>
        private static int round(int teams, out int element)
        {
            int half = teams;

            double twoPow = teams;
            int round = 0;

            while (half != 1)
            {
                half /= 2;
                twoPow /= 2;
                round++;
            }

            if (twoPow == 1)
            {
                round--;
            }

            element = (int)Math.Pow(2, round) - 1;

            return round;
        }

        private static int[] getElementDetail(int numberOfTeams, int numberOfElement, bool reverse)
        {
            int[] detail = new int[4];
            int[] rest = new int[4];

            int[] element = new int[numberOfElement];

            element[0] = numberOfTeams;

            for (int A = 1; A <= numberOfElement / 2; A++)
            {
                detail[1] = element[A - 1];

                for (int i = 1; i <= 2; i++)
                {
                    detail[i + 1] = detail[i] / 2;
                    rest[i] = detail[i] % 2;
                }

                int index = 2 * A - 1;
                if (A == 1)
                {
                    if (rest[1] == 0)
                    {
                        element[index] = detail[2];
                        element[index + 1] = detail[2];
                    }
                    else if (rest[1] == 1 && rest[2] == 0)
                    {
                        if (!reverse)
                        {
                            element[index] = detail[2] + 1;
                            element[index + 1] = detail[2];
                        }
                        else
                        {
                            element[index] = detail[2];
                            element[index + 1] = detail[2] + 1;
                        }
                    }
                    else if (rest[1] == 1 && rest[2] == 1)
                    {
                        if (!reverse)
                        {
                            element[index] = detail[2];
                            element[index + 1] = detail[2] + 1;
                        }
                        else
                        {
                            element[index] = detail[2] + 1;
                            element[index + 1] = detail[2];
                        }
                    }
                }
                else
                {
                    int oddNumber = A % 2;

                    switch (oddNumber)
                    {
                        case 1:
                            if (rest[1] == 0)
                            {
                                element[index] = detail[2];
                                element[index + 1] = detail[2];
                            }
                            else if (rest[1] == 1 && rest[2] == 0)
                            {
                                if (!reverse)
                                {
                                    element[index] = detail[2];
                                    element[index + 1] = detail[2] + 1;
                                }
                                else
                                {
                                    element[index] = detail[2] + 1;
                                    element[index + 1] = detail[2];
                                }
                            }
                            else if (rest[1] == 1 && rest[2] == 1)
                            {
                                if (!reverse)
                                {
                                    element[index] = detail[2] + 1;
                                    element[index + 1] = detail[2];
                                }
                                else
                                {
                                    element[index] = detail[2];
                                    element[index + 1] = detail[2] + 1;
                                }
                            }
                            break;
                        case 0:
                            if (rest[1] == 0)
                            {
                                element[index] = detail[2];
                                element[index + 1] = detail[2];
                            }
                            else if (rest[1] == 1 && rest[2] == 0)
                            {
                                if (!reverse)
                                {
                                    element[index] = detail[2] + 1;
                                    element[index + 1] = detail[2];
                                }
                                else
                                {
                                    element[index] = detail[2];
                                    element[index + 1] = detail[2] + 1;
                                }
                            }
                            else if (rest[1] == 1 && rest[2] == 1)
                            {
                                if (!reverse)
                                {
                                    element[index] = detail[2];
                                    element[index + 1] = detail[2] + 1;
                                }
                                else
                                {
                                    element[index] = detail[2] + 1;
                                    element[index + 1] = detail[2];
                                }
                            }
                            break;
                    }
                }
            }
            return element;
        }

        /// <summary>
        /// 次のシード番号の位置を返す
        /// </summary>
        /// <param name="tTemp">1回戦の対戦カード（シード番号）</param>
        /// <param name="pos">ひとつ前のシード位置</param>
        /// <param name="workFrames">作業用の枠数（出場チーム数以上の最小べき数）</param>
        /// <returns></returns>
        private static int nextSeedPosition(int[,] tTemp, int pos, int workFrames)
        {
            int nextPos = 0;
            int counter = 0;
            int nextLength = workFrames;
            int start = 0;
            while (nextLength > 1)
            {
                nextPos = nextLength - (pos - start) - 1 + start;
                if (tTemp[nextPos / 2, nextPos % 2] == 0)
                {
                    break;
                }
                counter++;
                nextLength /= 2;
                if (pos > nextLength)
                {
                    start = nextLength;
                }
                else
                {
                    start = 0;
                }
            }
            return nextPos;
        }

        /// <summary>
        /// 作業用の枠を確保し、シード番号を埋める
        /// </summary>
        /// <param name="partInfo">パート毎の情報</param>
        private void fillSeedNumber(BracketData.PartInfo partInfo, int numOfTeams)
        {
            partInfo.Round = BracketDataGenerator.round(numOfTeams, out int numOfElement);
            partInfo.NumberOfElement = numOfElement;

            int round = 0;
            while (partInfo.FullFrames < numOfTeams)
            {
                partInfo.FullFrames = (int)Math.Pow(2, round++);
            }

            if (BracketData.NumberOfSuperSeed == 0)
            {
                partInfo.Node = getElementDetail(numOfTeams, partInfo.NumberOfElement, false);
            }
            else
            {
                partInfo.Node =
                    getElementDetail(
                        numOfTeams, partInfo.NumberOfElement,
                        partInfo.PartNumber % 2 == 1 && partInfo.Round % 2 == 0);
            }

            int[] tSeedTemp = new int[partInfo.FullFrames];
            tSeedTemp[0] = 1;

            // １回戦対戦数分の配列を作り、シード番号を割り当てる
            int[,] tTemp = new int[partInfo.FullFrames / 2, 2];
            tTemp[0, 0] = 1;
            int seedNum = 2;
            int pos = 0;
            while ((pos = nextSeedPosition(tTemp, pos, partInfo.FullFrames)) != -1)
            {
                tTemp[pos / 2, pos % 2] = seedNum;
                tSeedTemp[pos] = seedNum;
                seedNum++;
                if (seedNum > partInfo.FullFrames)
                {
                    break;
                }
            }
            // 不要な枠を示す値（0）を設定する
            //partInfo.FirstRoundData = new int[partInfo.FullFrames / 2, 2];
            for (int i = 0; i < partInfo.FullFrames / 2; i++)
            {
                BracketData.RoundData roundData = new();
                for (int j = 0; j < 2; j++)
                {
                    if (tTemp[i, j] <= numOfTeams)
                    {
                        //partInfo.FirstRoundData[i, j] = tTemp[i, j];
                        roundData.Slots[j] = tTemp[i, j];
                    }
                    else
                    {
                        //partInfo.FirstRoundData[i, j] = 0;
                        roundData.Slots[j] = 0;
                    }
                }
                partInfo.FirstRoundData.Add(roundData);
            }

            return;
        }
        #endregion
    }
}
