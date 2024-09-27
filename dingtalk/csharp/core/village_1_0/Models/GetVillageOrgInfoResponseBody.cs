// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetVillageOrgInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("regionLocation")]
        [Validation(Required=false)]
        public string RegionLocation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>省份：PROVINCE;城市：CITY;县区：COUNTRY;乡镇：TOWN;村：VILLAGE</para>
        /// </summary>
        [NameInMap("regionType")]
        [Validation(Required=false)]
        public string RegionType { get; set; }

    }

}
