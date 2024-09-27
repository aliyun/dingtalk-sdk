// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusGetCampusGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>项目扩展信息</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试项目组</para>
        /// </summary>
        [NameInMap("projectGroupName")]
        [Validation(Required=false)]
        public string ProjectGroupName { get; set; }

    }

}
