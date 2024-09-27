// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OpenObjectiveDTO : TeaModel {
        [NameInMap("executor")]
        [Validation(Required=false)]
        public OpenUserDTO Executor { get; set; }

        [NameInMap("keyResults")]
        [Validation(Required=false)]
        public List<OpenKeyResultDTO> KeyResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>65222640d0e8b868f9f9ae3c</para>
        /// </summary>
        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public string ObjectiveId { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public OpenPeriodDTO Period { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("teams")]
        [Validation(Required=false)]
        public List<OpenTeamDTO> Teams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一个O的标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.00</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public double? Weight { get; set; }

    }

}
