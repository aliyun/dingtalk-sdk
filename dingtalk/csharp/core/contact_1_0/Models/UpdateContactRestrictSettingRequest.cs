// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateContactRestrictSettingRequest : TeaModel {
        /// <summary>
        /// 是否生效
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 白名单deptId列表
        /// </summary>
        [NameInMap("excludeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeDeptIds { get; set; }

        /// <summary>
        /// 白名单tagId列表
        /// </summary>
        [NameInMap("excludeTagIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeTagIds { get; set; }

        /// <summary>
        /// 白名单userid列表
        /// </summary>
        [NameInMap("excludeUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludeUserIds { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 主体的部门id列表
        /// </summary>
        [NameInMap("subjectDeptIds")]
        [Validation(Required=false)]
        public List<long?> SubjectDeptIds { get; set; }

        /// <summary>
        /// 主体的角色id列表
        /// </summary>
        [NameInMap("subjectTagIds")]
        [Validation(Required=false)]
        public List<long?> SubjectTagIds { get; set; }

        /// <summary>
        /// 主体的userId列表
        /// </summary>
        [NameInMap("subjectUserIds")]
        [Validation(Required=false)]
        public List<string> SubjectUserIds { get; set; }

        /// <summary>
        /// 限制类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
