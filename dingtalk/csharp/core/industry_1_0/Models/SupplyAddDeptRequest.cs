// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddDeptRequest : TeaModel {
        /// <summary>
        /// 部门名字
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// 供应商编号
        /// </summary>
        [NameInMap("partnerNumber")]
        [Validation(Required=false)]
        public string PartnerNumber { get; set; }

        /// <summary>
        /// 上级部门id
        /// </summary>
        [NameInMap("superDeptId")]
        [Validation(Required=false)]
        public long? SuperDeptId { get; set; }

        /// <summary>
        /// 供应链部门类型
        /// </summary>
        [NameInMap("supplyDeptType")]
        [Validation(Required=false)]
        public string SupplyDeptType { get; set; }

    }

}
