// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CustomizeContactListResponseBody : TeaModel {
        /// <summary>
        /// content
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CustomizeContactListResponseBodyContent> Content { get; set; }
        public class CustomizeContactListResponseBodyContent : TeaModel {
            /// <summary>
            /// 自定义通讯录Code
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 自定义通讯录名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 自定义通讯录排序
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            /// <summary>
            /// 跟部门Id
            /// </summary>
            [NameInMap("rootDeptId")]
            [Validation(Required=false)]
            public long? RootDeptId { get; set; }

        }

    }

}
