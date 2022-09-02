// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class RemovePermissionResponseBody : TeaModel {
        /// <summary>
        /// 当执行出错的时候，移除权限失败的用户昵称列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RemovePermissionResponseBodyData Data { get; set; }
        public class RemovePermissionResponseBodyData : TeaModel {
            [NameInMap("failNameList")]
            [Validation(Required=false)]
            public List<string> FailNameList { get; set; }

        }

        /// <summary>
        /// 服务端返回的错误代码
        /// </summary>
        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 描述本次调用的业务层面是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
