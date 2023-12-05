// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddCompetitionRecordRequest : TeaModel {
        [NameInMap("competitionCode")]
        [Validation(Required=false)]
        public string CompetitionCode { get; set; }

        [NameInMap("groupTemplateCode")]
        [Validation(Required=false)]
        public string GroupTemplateCode { get; set; }

        [NameInMap("joinGroup")]
        [Validation(Required=false)]
        public bool? JoinGroup { get; set; }

        [NameInMap("participantName")]
        [Validation(Required=false)]
        public string ParticipantName { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
