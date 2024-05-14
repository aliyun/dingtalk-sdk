// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportPerfEvalRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportPerfEvalRequestBody> Body { get; set; }
        public class HrbrainImportPerfEvalRequestBody : TeaModel {
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("perfCate")]
            [Validation(Required=false)]
            public string PerfCate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("perfPlanName")]
            [Validation(Required=false)]
            public string PerfPlanName { get; set; }

            [NameInMap("perfScore")]
            [Validation(Required=false)]
            public string PerfScore { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("periodEndDate")]
            [Validation(Required=false)]
            public string PeriodEndDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("periodStartDate")]
            [Validation(Required=false)]
            public string PeriodStartDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
