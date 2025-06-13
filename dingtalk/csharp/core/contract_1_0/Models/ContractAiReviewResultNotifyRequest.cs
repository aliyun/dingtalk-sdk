// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ContractAiReviewResultNotifyRequest : TeaModel {
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<ContractAiReviewResultNotifyRequestAnnotations> Annotations { get; set; }
        public class ContractAiReviewResultNotifyRequestAnnotations : TeaModel {
            [NameInMap("commentTexts")]
            [Validation(Required=false)]
            public List<ContractAiReviewResultNotifyRequestAnnotationsCommentTexts> CommentTexts { get; set; }
            public class ContractAiReviewResultNotifyRequestAnnotationsCommentTexts : TeaModel {
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("riskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("originalText")]
            [Validation(Required=false)]
            public string OriginalText { get; set; }

            [NameInMap("paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            [NameInMap("riskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contractAiReviewCorpId")]
        [Validation(Required=false)]
        public string ContractAiReviewCorpId { get; set; }

        [NameInMap("contractAiReviewId")]
        [Validation(Required=false)]
        public long? ContractAiReviewId { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
