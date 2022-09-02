// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectByTemplateResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateProjectByTemplateResponseBodyResult Result { get; set; }
        public class CreateProjectByTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 项目ID
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 项目图标地址
            /// </summary>
            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// 项目名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
