using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSupplierAssetModifyModel : AopObject
    {
        /// <summary>
        /// 供应商设备信息
        /// </summary>
        [XmlElement("record")]
        public SupplierAssetResponse Record { get; set; }
    }
}
