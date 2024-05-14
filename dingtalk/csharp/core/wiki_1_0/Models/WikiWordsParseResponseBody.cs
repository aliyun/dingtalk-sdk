// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwiki_1_0.Models
{
    public class WikiWordsParseResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<WikiWordsParseResponseBodyData> Data { get; set; }
        public class WikiWordsParseResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("endIndex")]
            [Validation(Required=false)]
            public long? EndIndex { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("startIndex")]
            [Validation(Required=false)]
            public long? StartIndex { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("wordName")]
            [Validation(Required=false)]
            public string WordName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
