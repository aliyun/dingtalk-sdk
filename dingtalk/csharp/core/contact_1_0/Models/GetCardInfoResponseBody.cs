// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetCardInfoResponseBody : TeaModel {
        [NameInMap("adminRole")]
        [Validation(Required=false)]
        public long? AdminRole { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public GetCardInfoResponseBodyExtension Extension { get; set; }
        public class GetCardInfoResponseBodyExtension : TeaModel {
            [NameInMap("cardContactInfo")]
            [Validation(Required=false)]
            public GetCardInfoResponseBodyExtensionCardContactInfo CardContactInfo { get; set; }
            public class GetCardInfoResponseBodyExtensionCardContactInfo : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public List<GetCardInfoResponseBodyExtensionCardContactInfoAddress> Address { get; set; }
                public class GetCardInfoResponseBodyExtensionCardContactInfoAddress : TeaModel {
                    [NameInMap("area")]
                    [Validation(Required=false)]
                    public GetCardInfoResponseBodyExtensionCardContactInfoAddressArea Area { get; set; }
                    public class GetCardInfoResponseBodyExtensionCardContactInfoAddressArea : TeaModel {
                        [NameInMap("region")]
                        [Validation(Required=false)]
                        public string Region { get; set; }

                        [NameInMap("regionFullName")]
                        [Validation(Required=false)]
                        public string RegionFullName { get; set; }

                    }

                    [NameInMap("detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                }

                [NameInMap("email")]
                [Validation(Required=false)]
                public List<GetCardInfoResponseBodyExtensionCardContactInfoEmail> Email { get; set; }
                public class GetCardInfoResponseBodyExtensionCardContactInfoEmail : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("link")]
                [Validation(Required=false)]
                public List<GetCardInfoResponseBodyExtensionCardContactInfoLink> Link { get; set; }
                public class GetCardInfoResponseBodyExtensionCardContactInfoLink : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("telephone")]
                [Validation(Required=false)]
                public List<GetCardInfoResponseBodyExtensionCardContactInfoTelephone> Telephone { get; set; }
                public class GetCardInfoResponseBodyExtensionCardContactInfoTelephone : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("workPhone")]
                [Validation(Required=false)]
                public List<GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone> WorkPhone { get; set; }
                public class GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("orgAuthed")]
            [Validation(Required=false)]
            public bool? OrgAuthed { get; set; }

            [NameInMap("orgLogo")]
            [Validation(Required=false)]
            public string OrgLogo { get; set; }

            [NameInMap("originCardUrl")]
            [Validation(Required=false)]
            public string OriginCardUrl { get; set; }

            [NameInMap("shareContent")]
            [Validation(Required=false)]
            public string ShareContent { get; set; }

            [NameInMap("thumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }

            [NameInMap("videoFileName")]
            [Validation(Required=false)]
            public string VideoFileName { get; set; }

            [NameInMap("videoTitle")]
            [Validation(Required=false)]
            public string VideoTitle { get; set; }

            [NameInMap("videoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        [NameInMap("industryName")]
        [Validation(Required=false)]
        public string IndustryName { get; set; }

        [NameInMap("introduce")]
        [Validation(Required=false)]
        public Dictionary<string, object> Introduce { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Settings { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
