// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class CreateSignFlowRequest : TeaModel {
        [NameInMap("bizFlowId")]
        [Validation(Required=false)]
        public string BizFlowId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("signDocs")]
        [Validation(Required=false)]
        public List<CreateSignFlowRequestSignDocs> SignDocs { get; set; }
        public class CreateSignFlowRequestSignDocs : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        [NameInMap("signFlowConfig")]
        [Validation(Required=false)]
        public CreateSignFlowRequestSignFlowConfig SignFlowConfig { get; set; }
        public class CreateSignFlowRequestSignFlowConfig : TeaModel {
            [NameInMap("autoStart")]
            [Validation(Required=false)]
            public bool? AutoStart { get; set; }

            [NameInMap("isOrderedSign")]
            [Validation(Required=false)]
            public bool? IsOrderedSign { get; set; }

            [NameInMap("signFlowName")]
            [Validation(Required=false)]
            public string SignFlowName { get; set; }

        }

        [NameInMap("signFlowInitiator")]
        [Validation(Required=false)]
        public CreateSignFlowRequestSignFlowInitiator SignFlowInitiator { get; set; }
        public class CreateSignFlowRequestSignFlowInitiator : TeaModel {
            [NameInMap("companyId")]
            [Validation(Required=false)]
            public string CompanyId { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("signers")]
        [Validation(Required=false)]
        public List<CreateSignFlowRequestSigners> Signers { get; set; }
        public class CreateSignFlowRequestSigners : TeaModel {
            [NameInMap("bizTaskId")]
            [Validation(Required=false)]
            public string BizTaskId { get; set; }

            [NameInMap("orgInfo")]
            [Validation(Required=false)]
            public CreateSignFlowRequestSignersOrgInfo OrgInfo { get; set; }
            public class CreateSignFlowRequestSignersOrgInfo : TeaModel {
                [NameInMap("companyId")]
                [Validation(Required=false)]
                public string CompanyId { get; set; }

                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

            }

            [NameInMap("signComponentConfig")]
            [Validation(Required=false)]
            public List<CreateSignFlowRequestSignersSignComponentConfig> SignComponentConfig { get; set; }
            public class CreateSignFlowRequestSignersSignComponentConfig : TeaModel {
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("signFieldComponentConfig")]
                [Validation(Required=false)]
                public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig SignFieldComponentConfig { get; set; }
                public class CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfig : TeaModel {
                    [NameInMap("availableOrgSealTypes")]
                    [Validation(Required=false)]
                    public List<string> AvailableOrgSealTypes { get; set; }

                    [NameInMap("availablePsnSealTypes")]
                    [Validation(Required=false)]
                    public List<string> AvailablePsnSealTypes { get; set; }

                    [NameInMap("crossPageType")]
                    [Validation(Required=false)]
                    public string CrossPageType { get; set; }

                    [NameInMap("signDateConfig")]
                    [Validation(Required=false)]
                    public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig SignDateConfig { get; set; }
                    public class CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignDateConfig : TeaModel {
                        [NameInMap("dateFormat")]
                        [Validation(Required=false)]
                        public string DateFormat { get; set; }

                        [NameInMap("showSignDate")]
                        [Validation(Required=false)]
                        public bool? ShowSignDate { get; set; }

                    }

                    [NameInMap("signPositionConfig")]
                    [Validation(Required=false)]
                    public CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig SignPositionConfig { get; set; }
                    public class CreateSignFlowRequestSignersSignComponentConfigSignFieldComponentConfigSignPositionConfig : TeaModel {
                        [NameInMap("positionPage")]
                        [Validation(Required=false)]
                        public long? PositionPage { get; set; }

                        [NameInMap("positionX")]
                        [Validation(Required=false)]
                        public double? PositionX { get; set; }

                        [NameInMap("positionY")]
                        [Validation(Required=false)]
                        public double? PositionY { get; set; }

                    }

                }

            }

            [NameInMap("signConfig")]
            [Validation(Required=false)]
            public CreateSignFlowRequestSignersSignConfig SignConfig { get; set; }
            public class CreateSignFlowRequestSignersSignConfig : TeaModel {
                [NameInMap("signOrder")]
                [Validation(Required=false)]
                public int? SignOrder { get; set; }

            }

            [NameInMap("signerInfo")]
            [Validation(Required=false)]
            public CreateSignFlowRequestSignersSignerInfo SignerInfo { get; set; }
            public class CreateSignFlowRequestSignersSignerInfo : TeaModel {
                [NameInMap("psnMobile")]
                [Validation(Required=false)]
                public string PsnMobile { get; set; }

                [NameInMap("psnName")]
                [Validation(Required=false)]
                public string PsnName { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("signerType")]
            [Validation(Required=false)]
            public string SignerType { get; set; }

        }

    }

}
