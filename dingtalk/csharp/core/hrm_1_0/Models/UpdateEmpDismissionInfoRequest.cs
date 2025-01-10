// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class UpdateEmpDismissionInfoRequest : TeaModel {
        [NameInMap("dismissionMemo")]
        [Validation(Required=false)]
        public string DismissionMemo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("lastWorkDate")]
        [Validation(Required=false)]
        public long? LastWorkDate { get; set; }

        [NameInMap("partner")]
        [Validation(Required=false)]
        public bool? Partner { get; set; }

        [NameInMap("terminationReasonPassive")]
        [Validation(Required=false)]
        public List<string> TerminationReasonPassive { get; set; }

        [NameInMap("terminationReasonVoluntary")]
        [Validation(Required=false)]
        public List<string> TerminationReasonVoluntary { get; set; }

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
