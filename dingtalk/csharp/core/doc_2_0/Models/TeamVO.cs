// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class TeamVO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://abc.com">https://abc.com</a></para>
        /// </summary>
        [NameInMap("cover")]
        [Validation(Required=false)]
        public string Cover { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12340000</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public TeamVOCreator Creator { get; set; }
        public class TeamVOCreator : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这里是团队描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://def.com">https://def.com</a></para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AbcDef</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试团队名称</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("relatedDeptInfo")]
        [Validation(Required=false)]
        public TeamVORelatedDeptInfo RelatedDeptInfo { get; set; }
        public class TeamVORelatedDeptInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试部门</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

        }

        [NameInMap("shareScopeInfo")]
        [Validation(Required=false)]
        public TeamVOShareScopeInfo ShareScopeInfo { get; set; }
        public class TeamVOShareScopeInfo : TeaModel {
            [NameInMap("roleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public int? Scope { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>34560000</para>
        /// </summary>
        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public long? UpdatedTime { get; set; }

        [NameInMap("updater")]
        [Validation(Required=false)]
        public TeamVOUpdater Updater { get; set; }
        public class TeamVOUpdater : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://abc.com">https://abc.com</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("visitInfo")]
        [Validation(Required=false)]
        public TeamVOVisitInfo VisitInfo { get; set; }
        public class TeamVOVisitInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }

        }

    }

}
