// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalTeamDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8535683xx</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部门</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6444f5e9a4261c6e699dxxxx</para>
        /// </summary>
        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

    }

}
