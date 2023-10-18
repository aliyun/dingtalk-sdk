// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreExportCardRecordDetailRequest : TeaModel {
        [NameInMap("beginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

        [NameInMap("sceneCardName")]
        [Validation(Required=false)]
        public string SceneCardName { get; set; }

    }

}
