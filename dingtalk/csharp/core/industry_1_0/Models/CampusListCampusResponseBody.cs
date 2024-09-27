// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusListCampusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CampusListCampusResponseBodyResult> Result { get; set; }
        public class CampusListCampusResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州市余杭区</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>121212.1</para>
            /// </summary>
            [NameInMap("area")]
            [Validation(Required=false)]
            public double? Area { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("belongProjectGroupId")]
            [Validation(Required=false)]
            public long? BelongProjectGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding121212</para>
            /// </summary>
            [NameInMap("campusCorpId")]
            [Validation(Required=false)]
            public string CampusCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("campusDeptId")]
            [Validation(Required=false)]
            public long? CampusDeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试园区</para>
            /// </summary>
            [NameInMap("campusName")]
            [Validation(Required=false)]
            public string CampusName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30450</para>
            /// </summary>
            [NameInMap("cityId")]
            [Validation(Required=false)]
            public int? CityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>中国</para>
            /// </summary>
            [NameInMap("country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>304501</para>
            /// </summary>
            [NameInMap("countyId")]
            [Validation(Required=false)]
            public int? CountyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>扩展</para>
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120.1321,28.1213</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1655704317794</para>
            /// </summary>
            [NameInMap("orderEndTime")]
            [Validation(Required=false)]
            public long? OrderEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>规格1</para>
            /// </summary>
            [NameInMap("orderInfo")]
            [Validation(Required=false)]
            public string OrderInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1655704317794</para>
            /// </summary>
            [NameInMap("orderStartTime")]
            [Validation(Required=false)]
            public long? OrderStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>304</para>
            /// </summary>
            [NameInMap("provId")]
            [Validation(Required=false)]
            public int? ProvId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13914773133</para>
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

        }

    }

}
