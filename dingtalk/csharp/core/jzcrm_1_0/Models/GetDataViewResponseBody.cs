// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class GetDataViewResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDataViewResponseBodyData Data { get; set; }
        public class GetDataViewResponseBodyData : TeaModel {
            /// <summary>
            /// 数据详情
            /// </summary>
            [NameInMap("detail")]
            [Validation(Required=false)]
            public Dictionary<string, string> Detail { get; set; }

        }

        /// <summary>
        /// 字段明细
        /// </summary>
        [NameInMap("dataname")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Dataname { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
