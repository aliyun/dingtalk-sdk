// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetTeamResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTeamResponseBodyResult Result { get; set; }
        public class GetTeamResponseBodyResult : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("dialectCode")]
            [Validation(Required=false)]
            public string DialectCode { get; set; }

            [NameInMap("dialectName")]
            [Validation(Required=false)]
            public string DialectName { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("sceneList")]
            [Validation(Required=false)]
            public List<GetTeamResponseBodyResultSceneList> SceneList { get; set; }
            public class GetTeamResponseBodyResultSceneList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("solutionCode")]
            [Validation(Required=false)]
            public string SolutionCode { get; set; }

            [NameInMap("solutionName")]
            [Validation(Required=false)]
            public string SolutionName { get; set; }

            [NameInMap("tagList")]
            [Validation(Required=false)]
            public List<GetTeamResponseBodyResultTagList> TagList { get; set; }
            public class GetTeamResponseBodyResultTagList : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("valueList")]
                [Validation(Required=false)]
                public List<GetTeamResponseBodyResultTagListValueList> ValueList { get; set; }
                public class GetTeamResponseBodyResultTagListValueList : TeaModel {
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
