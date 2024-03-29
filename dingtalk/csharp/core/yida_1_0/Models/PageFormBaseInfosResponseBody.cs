// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class PageFormBaseInfosResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PageFormBaseInfosResponseBodyResult Result { get; set; }
        public class PageFormBaseInfosResponseBodyResult : TeaModel {
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public List<PageFormBaseInfosResponseBodyResultData> Data { get; set; }
            public class PageFormBaseInfosResponseBodyResultData : TeaModel {
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("formType")]
                [Validation(Required=false)]
                public string FormType { get; set; }

                [NameInMap("formUuid")]
                [Validation(Required=false)]
                public string FormUuid { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public PageFormBaseInfosResponseBodyResultDataTitle Title { get; set; }
                public class PageFormBaseInfosResponseBodyResultDataTitle : TeaModel {
                    [NameInMap("enUS")]
                    [Validation(Required=false)]
                    public string EnUS { get; set; }

                    [NameInMap("zhCN")]
                    [Validation(Required=false)]
                    public string ZhCN { get; set; }

                }

            }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
