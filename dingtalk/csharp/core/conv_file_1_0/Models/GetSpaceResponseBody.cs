// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconv_file_1_0.Models
{
    public class GetSpaceResponseBody : TeaModel {
        /// <summary>
        /// IM会话存储空间信息
        /// </summary>
        [NameInMap("space")]
        [Validation(Required=false)]
        public GetSpaceResponseBodySpace Space { get; set; }
        public class GetSpaceResponseBodySpace : TeaModel {
            /// <summary>
            /// 空间归属企业的id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// 空间id
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

    }

}
