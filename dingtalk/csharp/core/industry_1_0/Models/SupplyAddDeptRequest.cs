// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddDeptRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        [NameInMap("partnerNumber")]
        [Validation(Required=false)]
        public string PartnerNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("superDeptId")]
        [Validation(Required=false)]
        public long? SuperDeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("supplyDeptType")]
        [Validation(Required=false)]
        public string SupplyDeptType { get; set; }

    }

}
