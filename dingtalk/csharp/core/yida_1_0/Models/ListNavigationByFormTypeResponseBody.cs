// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListNavigationByFormTypeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListNavigationByFormTypeResponseBodyResult> Result { get; set; }
        public class ListNavigationByFormTypeResponseBodyResult : TeaModel {
            /// <summary>
            /// formUuid
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// processCode
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// title
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public ListNavigationByFormTypeResponseBodyResultTitle Title { get; set; }
            public class ListNavigationByFormTypeResponseBodyResultTitle : TeaModel {
                /// <summary>
                /// 中文名称
                /// </summary>
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                /// <summary>
                /// 英文名称
                /// </summary>
                [NameInMap("nameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                /// <summary>
                /// type
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
