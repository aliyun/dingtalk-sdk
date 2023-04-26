// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class StartCoursePrepareRequest : TeaModel {
        [NameInMap("courseDate")]
        [Validation(Required=false)]
        public string CourseDate { get; set; }

        [NameInMap("courseGroupCode")]
        [Validation(Required=false)]
        public string CourseGroupCode { get; set; }

        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("liveCoverImage")]
        [Validation(Required=false)]
        public string LiveCoverImage { get; set; }

        [NameInMap("sectionIndex")]
        [Validation(Required=false)]
        public List<int?> SectionIndex { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
