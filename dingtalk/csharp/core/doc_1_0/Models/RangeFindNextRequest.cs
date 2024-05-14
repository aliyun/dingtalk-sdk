// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class RangeFindNextRequest : TeaModel {
        [NameInMap("findOptions")]
        [Validation(Required=false)]
        public RangeFindNextRequestFindOptions FindOptions { get; set; }
        public class RangeFindNextRequestFindOptions : TeaModel {
            [NameInMap("includeHidden")]
            [Validation(Required=false)]
            public bool? IncludeHidden { get; set; }

            [NameInMap("matchCase")]
            [Validation(Required=false)]
            public bool? MatchCase { get; set; }

            [NameInMap("matchEntireCell")]
            [Validation(Required=false)]
            public bool? MatchEntireCell { get; set; }

            [NameInMap("matchFormulaText")]
            [Validation(Required=false)]
            public bool? MatchFormulaText { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("useRegExp")]
            [Validation(Required=false)]
            public bool? UseRegExp { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
