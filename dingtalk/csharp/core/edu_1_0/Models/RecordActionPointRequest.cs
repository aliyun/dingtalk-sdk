// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class RecordActionPointRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPLOAD</para>
        /// </summary>
        [NameInMap("actionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1770361351000</para>
        /// </summary>
        [NameInMap("actionTime")]
        [Validation(Required=false)]
        public long? ActionTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding819xxxxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING_xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("taskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

    }

}
