// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidentInfoRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// 建筑面积，组多支持2位小数，总长不超过8位
        /// </summary>
        [NameInMap("buildingArea")]
        [Validation(Required=false)]
        public float? BuildingArea { get; set; }

        /// <summary>
        /// 市的名字，有值时provName必填
        /// </summary>
        [NameInMap("cityName")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// 1纯住宅；2:商住混合；3:办公；4:办公商业混合；5:商业；6:公共场所；7:其他
        /// </summary>
        [NameInMap("communityType")]
        [Validation(Required=false)]
        public long? CommunityType { get; set; }

        /// <summary>
        /// 区/县名，有值是provName，cityName必填
        /// </summary>
        [NameInMap("countyName")]
        [Validation(Required=false)]
        public string CountyName { get; set; }

        /// <summary>
        /// 经纬度，格式：经度,纬度
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// 小区名
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 省的名字
        /// </summary>
        [NameInMap("provName")]
        [Validation(Required=false)]
        public string ProvName { get; set; }

        /// <summary>
        /// 小区状态：0正常/1关闭/2作废
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public long? State { get; set; }

        /// <summary>
        /// 小区服务电话
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
