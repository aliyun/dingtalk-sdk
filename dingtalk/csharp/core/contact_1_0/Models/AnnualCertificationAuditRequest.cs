// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class AnnualCertificationAuditRequest : TeaModel {
        [NameInMap("applicantMobile")]
        [Validation(Required=false)]
        public string ApplicantMobile { get; set; }

        [NameInMap("applicantName")]
        [Validation(Required=false)]
        public string ApplicantName { get; set; }

        [NameInMap("applicationLetter")]
        [Validation(Required=false)]
        public string ApplicationLetter { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

        [NameInMap("certificateType")]
        [Validation(Required=false)]
        public int? CertificateType { get; set; }

        [NameInMap("corpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        [NameInMap("depositaryBank")]
        [Validation(Required=false)]
        public string DepositaryBank { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("legalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

        [NameInMap("licenseNumber")]
        [Validation(Required=false)]
        public string LicenseNumber { get; set; }

        [NameInMap("licenseUrl")]
        [Validation(Required=false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("publicAccount")]
        [Validation(Required=false)]
        public string PublicAccount { get; set; }

        [NameInMap("reasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        [NameInMap("reasonMsg")]
        [Validation(Required=false)]
        public string ReasonMsg { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
