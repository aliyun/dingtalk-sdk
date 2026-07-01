// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class UpdateTeamRequest : TeaModel {
        [NameInMap("dialectCode")]
        [Validation(Required=false)]
        public string DialectCode { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("sceneCodes")]
        [Validation(Required=false)]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("teamCode")]
        [Validation(Required=false)]
        public string TeamCode { get; set; }

    }

}
