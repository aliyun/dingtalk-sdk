// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetUsersRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18f923a7-5a5e-426d-94ae-a55ad1a4b240</para>
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isRecursive")]
        [Validation(Required=false)]
        public bool? IsRecursive { get; set; }

    }

}
