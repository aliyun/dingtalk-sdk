// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddCompetitionRecordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5F44C</para>
        /// </summary>
        [NameInMap("competitionCode")]
        [Validation(Required=false)]
        public string CompetitionCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edu</para>
        /// </summary>
        [NameInMap("groupTemplateCode")]
        [Validation(Required=false)]
        public string GroupTemplateCode { get; set; }

        [NameInMap("joinGroup")]
        [Validation(Required=false)]
        public bool? JoinGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>小明</para>
        /// </summary>
        [NameInMap("participantName")]
        [Validation(Required=false)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VYn5fYjORJMi</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
