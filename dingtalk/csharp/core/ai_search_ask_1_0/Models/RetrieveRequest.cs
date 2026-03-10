// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_search_ask_1_0.Models
{
    public class RetrieveRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("answerer")]
        [Validation(Required=false)]
        public string Answerer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("dragRequestContext")]
        [Validation(Required=false)]
        public RetrieveRequestDragRequestContext DragRequestContext { get; set; }
        public class RetrieveRequestDragRequestContext : TeaModel {
            [NameInMap("evaluationContext")]
            [Validation(Required=false)]
            public RetrieveRequestDragRequestContextEvaluationContext EvaluationContext { get; set; }
            public class RetrieveRequestDragRequestContextEvaluationContext : TeaModel {
                [NameInMap("sourceDentryId")]
                [Validation(Required=false)]
                public string SourceDentryId { get; set; }

            }

        }

        [NameInMap("keywordList")]
        [Validation(Required=false)]
        public List<string> KeywordList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("questioner")]
        [Validation(Required=false)]
        public string Questioner { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("retrievalExtendParams")]
        [Validation(Required=false)]
        public Dictionary<string, RetrievalExtendParamsValue> RetrievalExtendParams { get; set; }

        [NameInMap("retrieveScoreThreshold")]
        [Validation(Required=false)]
        public double? RetrieveScoreThreshold { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

        [NameInMap("tokenLimit")]
        [Validation(Required=false)]
        public int? TokenLimit { get; set; }

    }

}
