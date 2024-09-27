// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetBindChildInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding95eef8003c9ca8ca24f2f5cc6abecb85</para>
        /// </summary>
        [NameInMap("schoolCorpId")]
        [Validation(Required=false)]
        public string SchoolCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000000000307711730</para>
        /// </summary>
        [NameInMap("studentUserId")]
        [Validation(Required=false)]
        public string StudentUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X5y5kd8XiiqiScCl4Qlfy5GgiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
