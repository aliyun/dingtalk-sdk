// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetEmpAttributeHideBySceneSettingResponseBody : TeaModel {
        /// <summary>
        /// 单聊副标题场景配置，开启时单聊中相关的员工字段不显示
        /// </summary>
        [NameInMap("chatSubtitleConfig")]
        [Validation(Required=false)]
        public GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig ChatSubtitleConfig { get; set; }
        public class GetEmpAttributeHideBySceneSettingResponseBodyChatSubtitleConfig : TeaModel {
            /// <summary>
            /// 是否生效
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

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
        /// 隐藏字段id列表
        /// 枚举列表：
        ///         department：部门
        ///         email：邮箱
        ///         manager：直属主管
        ///         title：职位
        ///         mobile：手机号
        ///         ext_number：分机号
        ///         work_station：办公地点
        ///         remark：备注
        ///         hire_date：入职时间
        ///         job_number：工号
        /// </summary>
        [NameInMap("hideFields")]
        [Validation(Required=false)]
        public List<string> HideFields { get; set; }

        /// <summary>
        /// 设置id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 设置名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// 用户资料页场景配置，开启时相关的员工字段不在资料页中显示
        /// </summary>
        [NameInMap("profileSceneConfig")]
        [Validation(Required=false)]
        public GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig ProfileSceneConfig { get; set; }
        public class GetEmpAttributeHideBySceneSettingResponseBodyProfileSceneConfig : TeaModel {
            /// <summary>
            /// 是否生效
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

        /// <summary>
        /// 搜索场景配置，开启时隐藏的字段不在搜索结果中展示，并且不允许根据这些字段搜索到。
        /// </summary>
        [NameInMap("searchSceneConfig")]
        [Validation(Required=false)]
        public GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig SearchSceneConfig { get; set; }
        public class GetEmpAttributeHideBySceneSettingResponseBodySearchSceneConfig : TeaModel {
            /// <summary>
            /// 是否生效
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

        }

    }

}
