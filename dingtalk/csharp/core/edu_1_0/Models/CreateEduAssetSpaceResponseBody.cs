// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateEduAssetSpaceResponseBody : TeaModel {
        /// <summary>
        /// 创建时间戳
        /// </summary>
        [NameInMap("createTimeMillis")]
        [Validation(Required=false)]
        public long? CreateTimeMillis { get; set; }

        /// <summary>
        /// 修改时间戳
        /// </summary>
        [NameInMap("modifyTimeMillis")]
        [Validation(Required=false)]
        public long? ModifyTimeMillis { get; set; }

        /// <summary>
        /// 权限模型
        /// </summary>
        [NameInMap("permissionMode")]
        [Validation(Required=false)]
        public string PermissionMode { get; set; }

        /// <summary>
        /// 总容量
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// 空间id
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [NameInMap("spaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        /// <summary>
        /// 空间类型
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        /// <summary>
        /// 已使用容量
        /// </summary>
        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

    }

}
