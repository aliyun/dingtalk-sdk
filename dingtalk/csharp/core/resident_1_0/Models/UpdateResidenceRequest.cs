// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidenceRequest : TeaModel {
        /// <summary>
        /// 家庭管理员用户id
        /// </summary>
        [NameInMap("managerUserId")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// 户名字
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// 所属网格
        /// </summary>
        [NameInMap("grid")]
        [Validation(Required=false)]
        public string Grid { get; set; }

        /// <summary>
        /// 家庭电话
        /// </summary>
        [NameInMap("homeTel")]
        [Validation(Required=false)]
        public string HomeTel { get; set; }

        /// <summary>
        /// 是否是贫困户
        /// </summary>
        [NameInMap("destitute")]
        [Validation(Required=false)]
        public bool? Destitute { get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [NameInMap("parentDepartmentId")]
        [Validation(Required=false)]
        public long? ParentDepartmentId { get; set; }

    }

}
