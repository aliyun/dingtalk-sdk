// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class TeamVO : TeaModel {
        /// <summary>
        /// 封面
        /// </summary>
        [NameInMap("cover")]
        [Validation(Required=false)]
        public string Cover { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public TeamVOCreator Creator { get; set; }
        public class TeamVOCreator : TeaModel {
            /// <summary>
            /// 名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// unionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// 团队描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 团队ID
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 团队名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 关联部门信息
        /// </summary>
        [NameInMap("relatedDeptInfo")]
        [Validation(Required=false)]
        public TeamVORelatedDeptInfo RelatedDeptInfo { get; set; }
        public class TeamVORelatedDeptInfo : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

        }

        /// <summary>
        /// 团队状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 团队类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [NameInMap("updater")]
        [Validation(Required=false)]
        public TeamVOUpdater Updater { get; set; }
        public class TeamVOUpdater : TeaModel {
            /// <summary>
            /// 名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// unionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// 团队链接
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// 用户对这个团队的访问情况
        /// </summary>
        [NameInMap("visitInfo")]
        [Validation(Required=false)]
        public TeamVOVisitInfo VisitInfo { get; set; }
        public class TeamVOVisitInfo : TeaModel {
            /// <summary>
            /// 用户对这个团队的访问情况
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

    }

}
