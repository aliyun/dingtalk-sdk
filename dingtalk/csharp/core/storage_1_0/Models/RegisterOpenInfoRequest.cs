// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RegisterOpenInfoRequest : TeaModel {
        /// <summary>
        /// 注册打开信息
        /// </summary>
        [NameInMap("openInfos")]
        [Validation(Required=false)]
        public List<RegisterOpenInfoRequestOpenInfos> OpenInfos { get; set; }
        public class RegisterOpenInfoRequestOpenInfos : TeaModel {
            /// <summary>
            /// 打开方式
            /// 枚举值:
            /// 	PREVIEW: 预览
            /// 	EDIT: 编辑
            /// </summary>
            [NameInMap("openType")]
            [Validation(Required=false)]
            public string OpenType { get; set; }

            /// <summary>
            /// 注册链接
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// 链接供应商名称
        /// 枚举值:
        /// 	MS_OFFICE: MS Office
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
