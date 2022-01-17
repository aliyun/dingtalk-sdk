// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetCardInfoResponseBody : TeaModel {
        /// <summary>
        /// 头像
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 名片ID
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public GetCardInfoResponseBodyExtension Extension { get; set; }
        public class GetCardInfoResponseBodyExtension : TeaModel {
            [NameInMap("cardContactInfo")]
            [Validation(Required=false)]
            public GetCardInfoResponseBodyExtensionCardContactInfo CardContactInfo { get; set; }
            public class GetCardInfoResponseBodyExtensionCardContactInfo : TeaModel {
                /// <summary>
                /// 地址
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public List<GetCardInfoResponseBodyExtensionCardContactInfoAddress> Address { get; set; }
                public class GetCardInfoResponseBodyExtensionCardContactInfoAddress : TeaModel {
                    /// <summary>
                    /// 区域
                    /// </summary>
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
                    };

                    /// <summary>
                    /// 详细地址
                    /// </summary>
                    [NameInMap("detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                }

                /// <summary>
                /// 邮箱
                /// </summary>
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

                /// <summary>
                /// 电话
                /// </summary>
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

                /// <summary>
                /// 微信
                /// </summary>
                [NameInMap("wechat")]
                [Validation(Required=false)]
                public List<GetCardInfoResponseBodyExtensionCardContactInfoWechat> Wechat { get; set; }
                public class GetCardInfoResponseBodyExtensionCardContactInfoWechat : TeaModel {
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
            [NameInMap("orgAuthLevel")]
            [Validation(Required=false)]
            public long? OrgAuthLevel { get; set; }
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
        };

        /// <summary>
        /// 行业
        /// </summary>
        [NameInMap("industryName")]
        [Validation(Required=false)]
        public string IndustryName { get; set; }

        /// <summary>
        /// 是否主名片
        /// </summary>
        [NameInMap("introduce")]
        [Validation(Required=false)]
        public bool? Introduce { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
