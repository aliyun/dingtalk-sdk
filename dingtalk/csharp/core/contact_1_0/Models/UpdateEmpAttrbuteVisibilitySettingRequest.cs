// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateEmpAttrbuteVisibilitySettingRequest : TeaModel {
        /// <summary>
        /// 是否生效
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 例外部门id列表
        /// </summary>
        [NameInMap("excludeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeDeptIds { get; set; }

        /// <summary>
        /// 例外员工id列表
        /// </summary>
        [NameInMap("excludeStaffIds")]
        [Validation(Required=false)]
        public List<string> ExcludeStaffIds { get; set; }

        /// <summary>
        /// 例外角色id列表
        /// </summary>
        [NameInMap("excludeTagIds")]
        [Validation(Required=false)]
        public List<long?> ExcludeTagIds { get; set; }

        /// <summary>
        /// 隐藏字段id列表
        /// </summary>
        [NameInMap("hideFields")]
        [Validation(Required=false)]
        public List<string> HideFields { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// object部门id列表
        /// </summary>
        [NameInMap("objectDeptIds")]
        [Validation(Required=false)]
        public List<long?> ObjectDeptIds { get; set; }

        /// <summary>
        /// object员工id列表
        /// </summary>
        [NameInMap("objectStaffIds")]
        [Validation(Required=false)]
        public List<string> ObjectStaffIds { get; set; }

        /// <summary>
        /// object角色id列表
        /// </summary>
        [NameInMap("objectTagIds")]
        [Validation(Required=false)]
        public List<long?> ObjectTagIds { get; set; }

    }

}
