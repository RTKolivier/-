using System.Collections.Generic;
using System.Linq;
using Tmds.DBus.Protocol;

namespace курчас.Data;

public class Data_Price
{

    public int FindPrice(string acryl_Thickness, string acryl_size, int acryl_quality)
    {
        if (acryl_Thickness == "1,5 мм")
        {
            if (acryl_size == "3 см")
            {
                var price = DbHelper.context.ThreeOnehalves.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.ThreeonehalfQuantity)
                    {
                        return qua.ThreeonehalfPrice;
                    }
                }
            }
            else if (acryl_size == "5 см")
            {
                var price = DbHelper.context.FiveOnehalves.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.FiveonehalfQuantity)
                    {
                        return qua.FiveonehalfPrice;
                    }
                }
            }
            else if (acryl_size == "6 см")
            {
                var price = DbHelper.context.SixOnehalves.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.SixonehalfQuantity)
                    {
                        return qua.SixonehalfPrice;
                    }
                }
            }
            else if (acryl_size == "8 см")
            {
                var price = DbHelper.context.EightOnehalves.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.EightonehalfQuantity)
                    {
                        return qua.EightonehalfPrice;
                    }
                }
            }
            else if (acryl_size == "10 см")
            {
                var price = DbHelper.context.TenOnehalves.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.TenonehalfQuantity)
                    {
                        return qua.TenonehalfPrice;
                    }
                }
            }
        }
        else if (acryl_Thickness == "2 мм")
        {
            if (acryl_size == "3 см")
            {
                var price = DbHelper.context.ThreeTwos.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.ThreetwoQuantity)
                    {
                        return qua.ThreetwoPrice;
                    }
                }
            }
            else if (acryl_size == "5 см")
            {
                var price = DbHelper.context.FiveTwos.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.FivetwoQuantity)
                    {
                        return qua.FivetwoPrice;
                    }
                }
            }
            else if (acryl_size == "6 см")
            {
                var price = DbHelper.context.SixTwos.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.SixtwoQuantity)
                    {
                        return qua.SixtwoPrice;
                    }
                }
            }
            else if (acryl_size == "8 см")
            {
                var price = DbHelper.context.EightTwos.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.EighttwoQuantity)
                    {
                        return qua.EighttwoPrice;
                    }
                }
            }
            else if (acryl_size == "10 см")
            {
                var price = DbHelper.context.TenTwos.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.TentwoQuantity)
                    {
                        return qua.TentwoPrice;
                    }
                }
            }
        }
        else if (acryl_Thickness == "3 мм")
        {
            if (acryl_size == "3 см")
            {
                var price = DbHelper.context.ThreeThrees.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.ThreethreeQuantity)
                    {
                        return qua.ThreethreePrice;
                    }
                }
            }
            else if (acryl_size == "5 см")
            {
                var price = DbHelper.context.FiveThrees.ToList();

                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.FivethreeQuantity)
                    {
                        return qua.FivethreePrice;
                    }
                }
            }
            else if (acryl_size == "6 см")
            {
                var price = DbHelper.context.SixThrees.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.SixthreeQuantity)
                    {
                        return qua.SixthreePrice;
                    }
                }
            }
            else if (acryl_size == "8 см")
            {
                var price = DbHelper.context.EightThrees.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.EightthreeQuantity)
                    {
                        return qua.EightthreePrice;
                    }
                }
            }
            else if (acryl_size == "10 см")
            {
                var price = DbHelper.context.TenThrees.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.TenthreeQuantity)
                    {
                        return qua.TenthreePrice;
                    }
                }
            }
        }
        else if (acryl_Thickness == "4 мм")
        {
            if (acryl_size == "3 см")
            {
                var price = DbHelper.context.ThreeFours.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.ThreefourQuantity)
                    {
                        return qua.ThreefourPrice;
                    }
                }
            }
            else if (acryl_size == "5 см")
            {
                var price = DbHelper.context.FiveFours.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.FivefourQuantity)
                    {
                        return qua.FivefourPrice;
                    }
                }
            }
            else if (acryl_size == "6 см")
            {
                var price = DbHelper.context.SixFours.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.SixfourQuantity)
                    {
                        return qua.SixfourPrice;
                    }
                }
            }
            else if (acryl_size == "8 см")
            {
                var price = DbHelper.context.EightFours.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.EightfourQuantity)
                    {
                        return qua.EightfourPrice;
                    }
                }
            }
            else if (acryl_size == "10 см")
            {
                var price = DbHelper.context.TenFours.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.TenfourQuantity)
                    {
                        return qua.TenfourPrice;
                    }
                }
            }
        }
        else if (acryl_Thickness == "8 мм")
        {
            if (acryl_size == "3 см")
            {
                var price = DbHelper.context.ThreeEights.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.TeneightQuantity)
                    {
                        return qua.TeneightPrice;
                    }
                }
            }
            else if (acryl_size == "5 см")
            {
                var price = DbHelper.context.FiveEights.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.FiveeightQuantity)
                    {
                        return qua.FiveeightPrice;
                    }
                }
            }
            else if (acryl_size == "6 см")
            {
                var price = DbHelper.context.SixEights.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.SixeightQuantity)
                    {
                        return qua.SixeightPrice;
                    }
                }
            }
            else if (acryl_size == "8 см")
            {
                var price = DbHelper.context.EightEights.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.EighteightQuantity)
                    {
                        return qua.EighteightPrice;
                    }
                }
            }
            else if (acryl_size == "10 см")
            {
                var price = DbHelper.context.TenEights.ToList();
                foreach (var qua in price)
                {
                    if (acryl_quality <= qua.TeneightQuantity)
                    {
                        return qua.TeneightPrice;
                    }
                }
            }
        }

        return 0;
    }

}