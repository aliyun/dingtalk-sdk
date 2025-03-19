// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractAppsReviewTaskRequest : TeaModel {
        [NameInMap("contractFile")]
        [Validation(Required=false)]
        public CreateContractAppsReviewTaskRequestContractFile ContractFile { get; set; }
        public class CreateContractAppsReviewTaskRequestContractFile : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

        [NameInMap("contractFileDownloadUrl")]
        [Validation(Required=false)]
        public string ContractFileDownloadUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contractFileName")]
        [Validation(Required=false)]
        public string ContractFileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fileSource")]
        [Validation(Required=false)]
        public string FileSource { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("reviewCustomRules")]
        [Validation(Required=false)]
        public List<CreateContractAppsReviewTaskRequestReviewCustomRules> ReviewCustomRules { get; set; }
        public class CreateContractAppsReviewTaskRequestReviewCustomRules : TeaModel {
            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("ruleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            [NameInMap("ruleSequence")]
            [Validation(Required=false)]
            public string RuleSequence { get; set; }

            [NameInMap("ruleTag")]
            [Validation(Required=false)]
            public string RuleTag { get; set; }

            [NameInMap("ruleTitle")]
            [Validation(Required=false)]
            public string RuleTitle { get; set; }

        }

        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("standpoint")]
        [Validation(Required=false)]
        public string Standpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
