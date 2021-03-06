using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetinfoDeliverySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetinfoDeliverySyncModel : AopObject
    {
        /// <summary>
        /// 传入需要反馈的物料信息对象列表。
        /// </summary>
        [XmlArray("asset_infos")]
        [XmlArrayItem("asset_info_item")]
        public List<AssetInfoItem> AssetInfos { get; set; }
    }
}
