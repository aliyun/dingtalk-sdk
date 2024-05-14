// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class CreatePersonalTodoTaskRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("notifyConfigs")]
        [Validation(Required=false)]
        public CreatePersonalTodoTaskRequestNotifyConfigs NotifyConfigs { get; set; }
        public class CreatePersonalTodoTaskRequestNotifyConfigs : TeaModel {
            [NameInMap("dingNotify")]
            [Validation(Required=false)]
            public string DingNotify { get; set; }

        }

        [NameInMap("participantIds")]
        [Validation(Required=false)]
        public List<string> ParticipantIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
