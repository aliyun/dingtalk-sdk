// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreatePhysicalClassroomRequest : TeaModel {
        [NameInMap("classroomBuilding")]
        [Validation(Required=false)]
        public string ClassroomBuilding { get; set; }

        [NameInMap("classroomCampus")]
        [Validation(Required=false)]
        public string ClassroomCampus { get; set; }

        [NameInMap("classroomFloor")]
        [Validation(Required=false)]
        public string ClassroomFloor { get; set; }

        [NameInMap("classroomName")]
        [Validation(Required=false)]
        public string ClassroomName { get; set; }

        [NameInMap("classroomNumber")]
        [Validation(Required=false)]
        public string ClassroomNumber { get; set; }

        [NameInMap("directBroadcast")]
        [Validation(Required=false)]
        public string DirectBroadcast { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
