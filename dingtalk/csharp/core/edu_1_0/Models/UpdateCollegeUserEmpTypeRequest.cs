// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateCollegeUserEmpTypeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>college_student</para>
        /// </summary>
        [NameInMap("empType")]
        [Validation(Required=false)]
        public string EmpType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan666</para>
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
