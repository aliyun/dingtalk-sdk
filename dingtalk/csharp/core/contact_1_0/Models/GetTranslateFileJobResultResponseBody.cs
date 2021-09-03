// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetTranslateFileJobResultResponseBody : TeaModel {
        /// <summary>
        /// 0 任务进行中 1 任务处理成功 2 任务处理失败
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 文件内容转译成功后的url，需要用户通过oauth2授权登录在用户侧打开
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
