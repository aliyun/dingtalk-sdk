// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AddHrmLegalEntityRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("createUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public AddHrmLegalEntityRequestExt Ext { get; set; }
        public class AddHrmLegalEntityRequestExt : TeaModel {
            [NameInMap("legalEntityEnName")]
            [Validation(Required=false)]
            public string LegalEntityEnName { get; set; }

            [NameInMap("legalEntityEnShortName")]
            [Validation(Required=false)]
            public string LegalEntityEnShortName { get; set; }

            [NameInMap("legalEntityType")]
            [Validation(Required=false)]
            public string LegalEntityType { get; set; }

            [NameInMap("manageAddress")]
            [Validation(Required=false)]
            public AddHrmLegalEntityRequestExtManageAddress ManageAddress { get; set; }
            public class AddHrmLegalEntityRequestExtManageAddress : TeaModel {
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
                /// <para>123</para>
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>广州市</para>
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
                /// <para>广东省</para>
                /// </summary>
                [NameInMap("provinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

            }

            [NameInMap("registrationAddress")]
            [Validation(Required=false)]
            public AddHrmLegalEntityRequestExtRegistrationAddress RegistrationAddress { get; set; }
            public class AddHrmLegalEntityRequestExtRegistrationAddress : TeaModel {
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
                /// <para>123</para>
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>广州市</para>
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
                /// <para>广东省</para>
                /// </summary>
                [NameInMap("provinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

            }

            [NameInMap("registrationDate")]
            [Validation(Required=false)]
            public long? RegistrationDate { get; set; }

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
        /// </summary>
        [NameInMap("legalEntityName")]
        [Validation(Required=false)]
        public string LegalEntityName { get; set; }

        [NameInMap("legalEntityShortName")]
        [Validation(Required=false)]
        public string LegalEntityShortName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("legalEntityStatus")]
        [Validation(Required=false)]
        public int? LegalEntityStatus { get; set; }

        [NameInMap("legalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        [NameInMap("dingTenantId")]
        [Validation(Required=false)]
        public long? DingTenantId { get; set; }

    }

}
