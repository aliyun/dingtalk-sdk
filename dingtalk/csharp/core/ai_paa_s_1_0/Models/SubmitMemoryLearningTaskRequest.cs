// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class SubmitMemoryLearningTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("agentCode")]
        [Validation(Required=false)]
        public string AgentCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public SubmitMemoryLearningTaskRequestContent Content { get; set; }
        public class SubmitMemoryLearningTaskRequestContent : TeaModel {
            [NameInMap("knowledgeBaseUrl")]
            [Validation(Required=false)]
            public string KnowledgeBaseUrl { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("learningMode")]
        [Validation(Required=false)]
        public string LearningMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("memoryKey")]
        [Validation(Required=false)]
        public string MemoryKey { get; set; }

    }

}
