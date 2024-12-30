// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateContractReviewTaskRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("contractFile")]
        [Validation(Required=false)]
        public CreateContractReviewTaskRequestContractFile ContractFile { get; set; }
        public class CreateContractReviewTaskRequestContractFile : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>采购合同.doc</para>
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
        public List<CreateContractReviewTaskRequestReviewCustomRules> ReviewCustomRules { get; set; }
        public class CreateContractReviewTaskRequestReviewCustomRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>审查合同金额大小，不得低于1000元</para>
            /// </summary>
            [NameInMap("ruleDesc")]
            [Validation(Required=false)]
            public string RuleDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.1</para>
            /// </summary>
            [NameInMap("ruleSequence")]
            [Validation(Required=false)]
            public string RuleSequence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>金额相关规则</para>
            /// </summary>
            [NameInMap("ruleTag")]
            [Validation(Required=false)]
            public string RuleTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>合同金额校验</para>
            /// </summary>
            [NameInMap("ruleTitle")]
            [Validation(Required=false)]
            public string RuleTitle { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("ruleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("standpoint")]
        [Validation(Required=false)]
        public string Standpoint { get; set; }

    }

}
