// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class GetDataViewResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDataViewResponseBodyData Data { get; set; }
        public class GetDataViewResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public Dictionary<string, string> Detail { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataname")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Dataname { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
