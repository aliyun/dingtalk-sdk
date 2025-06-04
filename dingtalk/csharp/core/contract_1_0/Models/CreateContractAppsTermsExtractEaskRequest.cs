// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractAppsTermsExtractEaskRequest : TeaModel {
        [NameInMap("contractFile")]
        [Validation(Required=false)]
        public CreateContractAppsTermsExtractEaskRequestContractFile ContractFile { get; set; }
        public class CreateContractAppsTermsExtractEaskRequestContractFile : TeaModel {
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

        [NameInMap("contractFileName")]
        [Validation(Required=false)]
        public string ContractFileName { get; set; }

        [NameInMap("extractRules")]
        [Validation(Required=false)]
        public List<CreateContractAppsTermsExtractEaskRequestExtractRules> ExtractRules { get; set; }
        public class CreateContractAppsTermsExtractEaskRequestExtractRules : TeaModel {
            [NameInMap("ruleCategory")]
            [Validation(Required=false)]
            public string RuleCategory { get; set; }

            [NameInMap("termRules")]
            [Validation(Required=false)]
            public List<CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules> TermRules { get; set; }
            public class CreateContractAppsTermsExtractEaskRequestExtractRulesTermRules : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("termCategory")]
                [Validation(Required=false)]
                public string TermCategory { get; set; }

            }

        }

        [NameInMap("fileSource")]
        [Validation(Required=false)]
        public string FileSource { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
