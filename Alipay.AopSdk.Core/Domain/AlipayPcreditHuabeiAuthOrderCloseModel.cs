using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAuthOrderCloseModel : AopObject
    {
        /// <summary>
        /// 支付宝侧花呗冻结、解冻操作单据id。在原先的冻结或者解冻接口调用中同步返回给商户，或者通过商户通知返回给商户。推荐优先使用本参数。
        /// </summary>
        [XmlElement("auth_opt_id")]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 商户自定义的操作员信息，仅作记录用，无实际业务用途。
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户原先调用冻结、解冻接口传入的请求流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
