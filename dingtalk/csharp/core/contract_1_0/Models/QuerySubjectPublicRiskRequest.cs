// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QuerySubjectPublicRiskRequest : TeaModel {
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("companyId")]
        [Validation(Required=false)]
        public string CompanyId { get; set; }

        [NameInMap("contractAmount")]
        [Validation(Required=false)]
        public long? ContractAmount { get; set; }

        [NameInMap("contractType")]
        [Validation(Required=false)]
        public string ContractType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("creditCode")]
        [Validation(Required=false)]
        public string CreditCode { get; set; }

        [NameInMap("from")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("registrationNumber")]
        [Validation(Required=false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        [NameInMap("subjectName")]
        [Validation(Required=false)]
        public string SubjectName { get; set; }

    }

}
