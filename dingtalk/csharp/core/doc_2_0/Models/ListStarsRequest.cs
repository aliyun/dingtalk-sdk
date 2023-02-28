// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListStarsRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public ListStarsRequestOption Option { get; set; }
        public class ListStarsRequestOption : TeaModel {
            /// <summary>
            /// 文档类型
            /// 最大size:
            /// 	20
            /// </summary>
            [NameInMap("filterDocTypes")]
            [Validation(Required=false)]
            public List<string> FilterDocTypes { get; set; }

            /// <summary>
            /// 分页大小
            /// 默认值:
            /// 	20
            /// 最大值:
            /// 	20
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// 分页游标
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// 排序规则, 升降或降序
            /// 支持按字段排序，支持字段在orderBy中
            /// 枚举值:
            /// 	ASC: 升序
            /// 	DESC: 降序
            /// 默认值:
            /// 	ASC
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// 排序字段, 根据选择字段排序
            /// 枚举值:
            /// 	UPDATE_TIME: updateTime
            /// 	NAME: name
            /// 	CREATE_TIME: createTime
            /// </summary>
            [NameInMap("orderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

            /// <summary>
            /// 是否获取文档创建者名称
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withDentryCreatorInfo")]
            [Validation(Required=false)]
            public bool? WithDentryCreatorInfo { get; set; }

            /// <summary>
            /// 是否获取文档修改者名称
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withDentryModifierInfo")]
            [Validation(Required=false)]
            public bool? WithDentryModifierInfo { get; set; }

            /// <summary>
            /// 是否获取文档权限
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withDentryPermissionRole")]
            [Validation(Required=false)]
            public bool? WithDentryPermissionRole { get; set; }

            /// <summary>
            /// 是否获取知识库信息
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withSpaceDetail")]
            [Validation(Required=false)]
            public bool? WithSpaceDetail { get; set; }

            /// <summary>
            /// 是否获取知识库权限
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withSpacePermissionRole")]
            [Validation(Required=false)]
            public bool? WithSpacePermissionRole { get; set; }

            /// <summary>
            /// 是否获取小组信息
            /// 默认值:
            /// 	false
            /// </summary>
            [NameInMap("withTeamDetail")]
            [Validation(Required=false)]
            public bool? WithTeamDetail { get; set; }

        }

        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
