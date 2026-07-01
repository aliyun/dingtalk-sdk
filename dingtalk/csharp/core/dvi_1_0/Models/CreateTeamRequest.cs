// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class CreateTeamRequest : TeaModel {
        [NameInMap("adminUserIds")]
        [Validation(Required=false)]
        public List<string> AdminUserIds { get; set; }

        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<long?> DeptIds { get; set; }

        [NameInMap("dialectCode")]
        [Validation(Required=false)]
        public string DialectCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sceneCodes")]
        [Validation(Required=false)]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("solutionCode")]
        [Validation(Required=false)]
        public string SolutionCode { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
