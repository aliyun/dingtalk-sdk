// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainLabelCategoryTreeResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<HrbrainLabelCategoryTreeResponseBodyContent> Content { get; set; }
        public class HrbrainLabelCategoryTreeResponseBodyContent : TeaModel {
            [NameInMap("children")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Children { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("currentLabelNum")]
            [Validation(Required=false)]
            public long? CurrentLabelNum { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("pcode")]
            [Validation(Required=false)]
            public string Pcode { get; set; }

            [NameInMap("sortSize")]
            [Validation(Required=false)]
            public long? SortSize { get; set; }

            [NameInMap("totalLabelNum")]
            [Validation(Required=false)]
            public long? TotalLabelNum { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
