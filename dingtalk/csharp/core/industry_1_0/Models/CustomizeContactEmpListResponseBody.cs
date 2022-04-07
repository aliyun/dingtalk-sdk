// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CustomizeContactEmpListResponseBody : TeaModel {
        /// <summary>
        /// 人员信息列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CustomizeContactEmpListResponseBodyContent> Content { get; set; }
        public class CustomizeContactEmpListResponseBodyContent : TeaModel {
            /// <summary>
            /// 人员姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 人员Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
