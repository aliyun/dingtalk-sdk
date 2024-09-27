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
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public ListNavigationByFormTypeResponseBodyResultTitle Title { get; set; }
            public class ListNavigationByFormTypeResponseBodyResultTitle : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("nameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ZhangSan</para>
                /// </summary>
                [NameInMap("nameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
