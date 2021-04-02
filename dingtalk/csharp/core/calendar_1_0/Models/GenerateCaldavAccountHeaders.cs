// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class GenerateCaldavAccountHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// 授权本次调用的用户id，该字段有值时认为本次调用已被授权访问该用户可以访问的所有数据
        /// </summary>
        [NameInMap("dingUid")]
        [Validation(Required=false)]
        public string DingUid { get; set; }

        [NameInMap("x-acs-dingtalk-access-token")]
        [Validation(Required=false)]
        public string XAcsDingtalkAccessToken { get; set; }

    }

}
