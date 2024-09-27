// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusGetCampusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>##街道</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("area")]
        [Validation(Required=false)]
        public double? Area { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1011</para>
        /// </summary>
        [NameInMap("belongProjectGroupId")]
        [Validation(Required=false)]
        public string BelongProjectGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding121212</para>
        /// </summary>
        [NameInMap("campusCorpId")]
        [Validation(Required=false)]
        public string CampusCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
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
        /// <para>100</para>
        /// </summary>
        [NameInMap("capacity")]
        [Validation(Required=false)]
        public string Capacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2030</para>
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
        /// <para>203040</para>
        /// </summary>
        [NameInMap("countyId")]
        [Validation(Required=false)]
        public int? CountyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>描述</para>
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
        /// <para>120.1,28.1</para>
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
        /// <para>购买信息</para>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("provId")]
        [Validation(Required=false)]
        public int? ProvId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13914772123</para>
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
