// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetSolutionConfigResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSolutionConfigResponseBodyResult Result { get; set; }
        public class GetSolutionConfigResponseBodyResult : TeaModel {
            [NameInMap("dialectList")]
            [Validation(Required=false)]
            public List<GetSolutionConfigResponseBodyResultDialectList> DialectList { get; set; }
            public class GetSolutionConfigResponseBodyResultDialectList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("solutionList")]
            [Validation(Required=false)]
            public List<GetSolutionConfigResponseBodyResultSolutionList> SolutionList { get; set; }
            public class GetSolutionConfigResponseBodyResultSolutionList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sceneList")]
                [Validation(Required=false)]
                public List<GetSolutionConfigResponseBodyResultSolutionListSceneList> SceneList { get; set; }
                public class GetSolutionConfigResponseBodyResultSolutionListSceneList : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

    }

}
