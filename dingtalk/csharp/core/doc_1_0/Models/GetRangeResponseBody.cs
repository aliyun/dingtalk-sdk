// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetRangeResponseBody : TeaModel {
        [NameInMap("backgroundColors")]
        [Validation(Required=false)]
        public List<List<GetRangeResponseBodyBackgroundColors>> BackgroundColors { get; set; }
        public class GetRangeResponseBodyBackgroundColors : TeaModel {
            [NameInMap("red")]
            [Validation(Required=false)]
            public int? Red { get; set; }

            [NameInMap("green")]
            [Validation(Required=false)]
            public int? Green { get; set; }

            [NameInMap("blue")]
            [Validation(Required=false)]
            public int? Blue { get; set; }

            [NameInMap("hexString")]
            [Validation(Required=false)]
            public string HexString { get; set; }

        }

        [NameInMap("displayValues")]
        [Validation(Required=false)]
        public List<List<string>> DisplayValues { get; set; }

        [NameInMap("fontSizes")]
        [Validation(Required=false)]
        public List<List<int?>> FontSizes { get; set; }

        [NameInMap("formulas")]
        [Validation(Required=false)]
        public List<List<string>> Formulas { get; set; }

        [NameInMap("horizontalAlignments")]
        [Validation(Required=false)]
        public List<List<string>> HorizontalAlignments { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<object>> Values { get; set; }

        [NameInMap("verticalAlignments")]
        [Validation(Required=false)]
        public List<List<string>> VerticalAlignments { get; set; }

    }

}
