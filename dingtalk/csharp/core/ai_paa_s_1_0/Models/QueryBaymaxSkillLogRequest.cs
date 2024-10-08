// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class QueryBaymaxSkillLogRequest : TeaModel {
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14da****2760</para>
        /// </summary>
        [NameInMap("logLevel")]
        [Validation(Required=false)]
        public string LogLevel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14da****2760</para>
        /// </summary>
        [NameInMap("skillExecuteId")]
        [Validation(Required=false)]
        public string SkillExecuteId { get; set; }

        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}
