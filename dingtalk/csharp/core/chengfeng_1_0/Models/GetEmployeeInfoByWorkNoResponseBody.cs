// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetEmployeeInfoByWorkNoResponseBody : TeaModel {
        /// <summary>
        /// 请求返回数据对象
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetEmployeeInfoByWorkNoResponseBodyContent Content { get; set; }
        public class GetEmployeeInfoByWorkNoResponseBodyContent : TeaModel {
            /// <summary>
            /// 员工姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 员工工号
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        /// <summary>
        /// 接口请求成功标识,成功为true,失败为false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
