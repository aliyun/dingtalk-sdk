// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class AnnualCertificationAuditRequest : TeaModel {
        /// <summary>
        /// 申请人手机号。
        /// </summary>
        [NameInMap("applicantMobile")]
        [Validation(Required=false)]
        public string ApplicantMobile { get; set; }

        /// <summary>
        /// 申请人姓名。
        /// </summary>
        [NameInMap("applicantName")]
        [Validation(Required=false)]
        public string ApplicantName { get; set; }

        /// <summary>
        /// 认证/修改认证授权函
        /// </summary>
        [NameInMap("applicationLetter")]
        [Validation(Required=false)]
        public string ApplicationLetter { get; set; }

        /// <summary>
        /// 结果状态  
        /// 1: 认证中预警 和 认证中需要补充材料 合并，通过code区分 
        /// 2:认证失败 
        /// 3:审核通过
        /// </summary>
        [NameInMap("authStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

        /// <summary>
        /// 证书类型：
        /// 
        /// 0：社会统一信用代码
        /// 
        /// 1：其它
        /// </summary>
        [NameInMap("certificateType")]
        [Validation(Required=false)]
        public int? CertificateType { get; set; }

        /// <summary>
        /// 用户提交的企业名称
        /// </summary>
        [NameInMap("corpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// 开户行。
        /// </summary>
        [NameInMap("depositaryBank")]
        [Validation(Required=false)]
        public string DepositaryBank { get; set; }

        /// <summary>
        /// 扩展字段，json格式传递，传递上面字段的额外字段。
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// 法人姓名。
        /// </summary>
        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        /// <summary>
        /// 证件号：
        /// 
        /// 营业执照注册号（一般15位）
        /// 
        /// 社会统一信用代码（固定18位）
        /// 
        /// 组织机构代码证号（格式11111111-1）
        /// </summary>
        [NameInMap("licenseNumber")]
        [Validation(Required=false)]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// 企业证件照片url。
        /// </summary>
        [NameInMap("licenseUrl")]
        [Validation(Required=false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 对公账号。
        /// </summary>
        [NameInMap("publicAccount")]
        [Validation(Required=false)]
        public string PublicAccount { get; set; }

        /// <summary>
        /// 失败原因，认证中预警 和 认证中需要补充材料以及认证失败时需要提供。
        /// </summary>
        [NameInMap("reasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        [NameInMap("reasonMsg")]
        [Validation(Required=false)]
        public string ReasonMsg { get; set; }

        /// <summary>
        /// 送审打标类型：
        /// 
        /// "V":四要素通过
        /// 
        /// "AV"：四要素未通过
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
