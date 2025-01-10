// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class EmpStartDismissionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("lastWorkDate")]
        [Validation(Required=false)]
        public long? LastWorkDate { get; set; }

        [NameInMap("partner")]
        [Validation(Required=false)]
        public bool? Partner { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("terminationReasonPassive")]
        [Validation(Required=false)]
        public List<string> TerminationReasonPassive { get; set; }

        [NameInMap("terminationReasonVoluntary")]
        [Validation(Required=false)]
        public List<string> TerminationReasonVoluntary { get; set; }

        [NameInMap("toHireBlackList")]
        [Validation(Required=false)]
        public bool? ToHireBlackList { get; set; }

        [NameInMap("toHireDismissionTalent")]
        [Validation(Required=false)]
        public bool? ToHireDismissionTalent { get; set; }

        [NameInMap("toHrmBlackList")]
        [Validation(Required=false)]
        public bool? ToHrmBlackList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2163515669935611</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
