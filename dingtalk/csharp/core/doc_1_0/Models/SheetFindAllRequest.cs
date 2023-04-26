// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SheetFindAllRequest : TeaModel {
        [NameInMap("findOptions")]
        [Validation(Required=false)]
        public SheetFindAllRequestFindOptions FindOptions { get; set; }
        public class SheetFindAllRequestFindOptions : TeaModel {
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

            [NameInMap("unionCells")]
            [Validation(Required=false)]
            public bool? UnionCells { get; set; }

            [NameInMap("useRegExp")]
            [Validation(Required=false)]
            public bool? UseRegExp { get; set; }

        }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("select")]
        [Validation(Required=false)]
        public string Select { get; set; }

    }

}
