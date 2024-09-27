// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyAddDeptRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>闪电供应商</para>
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>G12345</para>
        /// </summary>
        [NameInMap("partnerNumber")]
        [Validation(Required=false)]
        public string PartnerNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("superDeptId")]
        [Validation(Required=false)]
        public long? SuperDeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUPPLY_CHAIN_DEPT_TYPE</para>
        /// </summary>
        [NameInMap("supplyDeptType")]
        [Validation(Required=false)]
        public string SupplyDeptType { get; set; }

    }

}
