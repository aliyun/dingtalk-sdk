// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateContactHideBySceneSettingRequest : TeaModel {
        /// <summary>
        /// 设置描述信息
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 允许查看的部门列表
        /// </summary>
        [NameInMap("excludeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeDeptIds { get; set; }

        /// <summary>
        /// 允许查看的角色列表
        /// </summary>
        [NameInMap("excludeTagIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeTagIds { get; set; }

        /// <summary>
        /// 允许查看的员工列表
        /// </summary>
        [NameInMap("excludeUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeUserIds { get; set; }

        /// <summary>
        /// 设置名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 浏览组织架构与选人组件场景下的配置
        /// </summary>
        [NameInMap("nodeListSceneConfig")]
        [Validation(Required=false)]
        public UpdateContactHideBySceneSettingRequestNodeListSceneConfig NodeListSceneConfig { get; set; }
        public class UpdateContactHideBySceneSettingRequestNodeListSceneConfig : TeaModel {
            /// <summary>
            /// 是否在浏览组织架构与选人组件中生效，默认为true
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// 是否同时隐藏被隐藏部门下的员工，默认为true。如果为false，仅部门不可见，但是允许跳转到被隐藏部门查看部门下员工。
            /// </summary>
            [NameInMap("deptObjectIncludeEmp")]
            [Validation(Required=false)]
            public bool? DeptObjectIncludeEmp { get; set; }

        }

        /// <summary>
        /// 被隐藏的部门列表
        /// </summary>
        [NameInMap("objectDeptIds")]
        [Validation(Required=false)]
        public List<long?> ObjectDeptIds { get; set; }

        /// <summary>
        /// 被隐藏的角色列表
        /// </summary>
        [NameInMap("objectTagIds")]
        [Validation(Required=false)]
        public List<long?> ObjectTagIds { get; set; }

        /// <summary>
        /// 被隐藏的员工UserId列表
        /// </summary>
        [NameInMap("objectUserIds")]
        [Validation(Required=false)]
        public List<string> ObjectUserIds { get; set; }

        /// <summary>
        /// 用户详情场景下的配置
        /// </summary>
        [NameInMap("profileSceneConfig")]
        [Validation(Required=false)]
        public UpdateContactHideBySceneSettingRequestProfileSceneConfig ProfileSceneConfig { get; set; }
        public class UpdateContactHideBySceneSettingRequestProfileSceneConfig : TeaModel {
            /// <summary>
            /// 是否在用户详情页面生效，默认为true。如果为false，仍然允许查看个人资料页中的员工信息。
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

        /// <summary>
        /// 搜索的场景配置（包括搜索部门、搜索员工）
        /// </summary>
        [NameInMap("searchSceneConfig")]
        [Validation(Required=false)]
        public UpdateContactHideBySceneSettingRequestSearchSceneConfig SearchSceneConfig { get; set; }
        public class UpdateContactHideBySceneSettingRequestSearchSceneConfig : TeaModel {
            /// <summary>
            /// 是否在搜索场景生效，默认为true。如果为false，允许被搜索。
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// 是否同时隐藏被隐藏的部门下的员工，默认为true。如果为false，objectDeptIds中的部门无法被搜索，但是员工仍然可以被搜索
            /// </summary>
            [NameInMap("deptObjectIncludeEmp")]
            [Validation(Required=false)]
            public bool? DeptObjectIncludeEmp { get; set; }

        }

    }

}
