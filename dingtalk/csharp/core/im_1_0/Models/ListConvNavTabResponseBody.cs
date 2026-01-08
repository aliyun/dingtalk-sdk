// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ListConvNavTabResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListConvNavTabResponseBodyResult Result { get; set; }
        public class ListConvNavTabResponseBodyResult : TeaModel {
            [NameInMap("convNavTabInfos")]
            [Validation(Required=false)]
            public List<ListConvNavTabResponseBodyResultConvNavTabInfos> ConvNavTabInfos { get; set; }
            public class ListConvNavTabResponseBodyResultConvNavTabInfos : TeaModel {
                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                [NameInMap("tabId")]
                [Validation(Required=false)]
                public string TabId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("userEditable")]
                [Validation(Required=false)]
                public bool? UserEditable { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
