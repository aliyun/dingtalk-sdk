// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryEduAssetSpacesResponseBody : TeaModel {
        /// <summary>
        /// 是否还有数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 空间结果集
        /// </summary>
        [NameInMap("spaces")]
        [Validation(Required=false)]
        public List<QueryEduAssetSpacesResponseBodySpaces> Spaces { get; set; }
        public class QueryEduAssetSpacesResponseBodySpaces : TeaModel {
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
            /// 空间容量
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// 已使用容量
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

            /// <summary>
            /// 权限类型acl：acl授权；custom：自定义授权
            /// </summary>
            [NameInMap("permissionMode")]
            [Validation(Required=false)]
            public string PermissionMode { get; set; }

            /// <summary>
            /// 创建时间的时间戳
            /// </summary>
            [NameInMap("createTimeMillis")]
            [Validation(Required=false)]
            public long? CreateTimeMillis { get; set; }

            /// <summary>
            /// 修改时间的时间戳
            /// </summary>
            [NameInMap("modifyTimeMillis")]
            [Validation(Required=false)]
            public long? ModifyTimeMillis { get; set; }

        }

    }

}
