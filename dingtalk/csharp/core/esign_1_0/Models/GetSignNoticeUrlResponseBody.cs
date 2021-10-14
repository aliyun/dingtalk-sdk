// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetSignNoticeUrlResponseBody : TeaModel {
        /// <summary>
        /// 返回错误码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSignNoticeUrlResponseBodyData Data { get; set; }
        public class GetSignNoticeUrlResponseBodyData : TeaModel {
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }
        };

        /// <summary>
        /// 返回结果信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
