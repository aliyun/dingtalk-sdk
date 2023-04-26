// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskExecutorResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskExecutorResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskExecutorResponseBodyResult : TeaModel {
            [NameInMap("executor")]
            [Validation(Required=false)]
            public UpdateOrganizationTaskExecutorResponseBodyResultExecutor Executor { get; set; }
            public class UpdateOrganizationTaskExecutorResponseBodyResultExecutor : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("involvers")]
            [Validation(Required=false)]
            public List<UpdateOrganizationTaskExecutorResponseBodyResultInvolvers> Involvers { get; set; }
            public class UpdateOrganizationTaskExecutorResponseBodyResultInvolvers : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
