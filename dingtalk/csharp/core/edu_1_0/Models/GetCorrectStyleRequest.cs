// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetCorrectStyleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding123...</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding_scan_correct_...</para>
        /// </summary>
        [NameInMap("taskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

    }

}
