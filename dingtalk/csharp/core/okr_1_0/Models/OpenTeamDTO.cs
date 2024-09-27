// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OpenTeamDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0342464558835299</para>
        /// </summary>
        [NameInMap("deptUid")]
        [Validation(Required=false)]
        public string DeptUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64cd2e9bb80efb17244c650d</para>
        /// </summary>
        [NameInMap("dingDeptId")]
        [Validation(Required=false)]
        public string DingDeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx部门</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
