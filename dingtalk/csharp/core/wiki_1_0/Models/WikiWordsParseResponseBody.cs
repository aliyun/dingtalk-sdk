// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_1_0.Models
{
    public class WikiWordsParseResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<WikiWordsParseResponseBodyData> Data { get; set; }
        public class WikiWordsParseResponseBodyData : TeaModel {
            [NameInMap("endIndex")]
            [Validation(Required=false)]
            public long? EndIndex { get; set; }

            [NameInMap("startIndex")]
            [Validation(Required=false)]
            public long? StartIndex { get; set; }

            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

        }

        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
