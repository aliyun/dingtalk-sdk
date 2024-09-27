// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UpdateSeniorSettingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("open")]
        [Validation(Required=false)]
        public bool? Open { get; set; }

        [NameInMap("permitDeptIds")]
        [Validation(Required=false)]
        public List<long?> PermitDeptIds { get; set; }

        [NameInMap("permitStaffIds")]
        [Validation(Required=false)]
        public List<string> PermitStaffIds { get; set; }

        [NameInMap("permitTagIds")]
        [Validation(Required=false)]
        public List<long?> PermitTagIds { get; set; }

        [NameInMap("protectScenes")]
        [Validation(Required=false)]
        public List<string> ProtectScenes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("seniorStaffId")]
        [Validation(Required=false)]
        public string SeniorStaffId { get; set; }

    }

}
