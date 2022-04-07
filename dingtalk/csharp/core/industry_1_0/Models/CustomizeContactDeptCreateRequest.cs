// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CustomizeContactDeptCreateRequest : TeaModel {
        /// <summary>
        /// 自定义通讯录Code
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 部门主管列表
        /// </summary>
        [NameInMap("managerIdList")]
        [Validation(Required=false)]
        public List<string> ManagerIdList { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 部门排序
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        /// <summary>
        /// 上级部门Id
        /// </summary>
        [NameInMap("parentDeptId")]
        [Validation(Required=false)]
        public long? ParentDeptId { get; set; }

        /// <summary>
        /// 引用的内部通讯录部门Id
        /// </summary>
        [NameInMap("refId")]
        [Validation(Required=false)]
        public long? RefId { get; set; }

        /// <summary>
        /// 部门类型 0:普通部门 1:引用部门
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
