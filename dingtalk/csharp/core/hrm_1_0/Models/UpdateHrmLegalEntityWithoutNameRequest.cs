// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class UpdateHrmLegalEntityWithoutNameRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("createUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public UpdateHrmLegalEntityWithoutNameRequestExt Ext { get; set; }
        public class UpdateHrmLegalEntityWithoutNameRequestExt : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>company</para>
            /// </summary>
            [NameInMap("legalEntityEnName")]
            [Validation(Required=false)]
            public string LegalEntityEnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>com</para>
            /// </summary>
            [NameInMap("legalEntityEnShortName")]
            [Validation(Required=false)]
            public string LegalEntityEnShortName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>whollyOwned</para>
            /// </summary>
            [NameInMap("legalEntityType")]
            [Validation(Required=false)]
            public string LegalEntityType { get; set; }

            [NameInMap("manageAddress")]
            [Validation(Required=false)]
            public UpdateHrmLegalEntityWithoutNameRequestExtManageAddress ManageAddress { get; set; }
            public class UpdateHrmLegalEntityWithoutNameRequestExtManageAddress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>110101</para>
                /// </summary>
                [NameInMap("areaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>东城区</para>
                /// </summary>
                [NameInMap("areaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>广州</para>
                /// </summary>
                [NameInMap("cityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("countryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("countryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>北京市东城区xx街道xx小区xx楼</para>
                /// </summary>
                [NameInMap("detailAddress")]
                [Validation(Required=false)]
                public string DetailAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("globalAreaType")]
                [Validation(Required=false)]
                public string GlobalAreaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>广东</para>
                /// </summary>
                [NameInMap("provinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

            }

            [NameInMap("registrationAddress")]
            [Validation(Required=false)]
            public UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress RegistrationAddress { get; set; }
            public class UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>110101</para>
                /// </summary>
                [NameInMap("areaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>东城区</para>
                /// </summary>
                [NameInMap("areaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>广州</para>
                /// </summary>
                [NameInMap("cityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("countryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("countryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>北京市东城区xx街道xx小区xx楼</para>
                /// </summary>
                [NameInMap("detailAddress")]
                [Validation(Required=false)]
                public string DetailAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("globalAreaType")]
                [Validation(Required=false)]
                public string GlobalAreaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>广东</para>
                /// </summary>
                [NameInMap("provinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-01-01</para>
            /// </summary>
            [NameInMap("registrationDate")]
            [Validation(Required=false)]
            public long? RegistrationDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("unifiedSocialCreditCode")]
            [Validation(Required=false)]
            public string UnifiedSocialCreditCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>515200</para>
            /// </summary>
            [NameInMap("zipCode")]
            [Validation(Required=false)]
            public string ZipCode { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>公司1</para>
        /// </summary>
        [NameInMap("legalEntityName")]
        [Validation(Required=false)]
        public string LegalEntityName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>公1</para>
        /// </summary>
        [NameInMap("legalEntityShortName")]
        [Validation(Required=false)]
        public string LegalEntityShortName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("legalEntityStatus")]
        [Validation(Required=false)]
        public int? LegalEntityStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>法人</para>
        /// </summary>
        [NameInMap("legalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("dingTenantId")]
        [Validation(Required=false)]
        public long? DingTenantId { get; set; }

    }

}
