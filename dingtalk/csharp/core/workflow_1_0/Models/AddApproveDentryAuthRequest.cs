// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class AddApproveDentryAuthRequest : TeaModel {
        /// <summary>
        /// 授权的钉盘文件信息列表。支持批量授权，最大列表长度：10。
        /// </summary>
        [NameInMap("fileInfos")]
        [Validation(Required=false)]
        public List<AddApproveDentryAuthRequestFileInfos> FileInfos { get; set; }
        public class AddApproveDentryAuthRequestFileInfos : TeaModel {
            /// <summary>
            /// 文件ID。
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// 钉盘空间spaceId。
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        /// <summary>
        /// 授权的用户userid。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
