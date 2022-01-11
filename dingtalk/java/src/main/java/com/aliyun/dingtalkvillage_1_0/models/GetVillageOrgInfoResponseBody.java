// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetVillageOrgInfoResponseBody extends TeaModel {
    // 行政区ID
    @NameInMap("regionId")
    public String regionId;

    // 具体的企业区域位置信息
    @NameInMap("regionLocation")
    public String regionLocation;

    // 区域类型
    @NameInMap("regionType")
    public String regionType;

    public static GetVillageOrgInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetVillageOrgInfoResponseBody self = new GetVillageOrgInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetVillageOrgInfoResponseBody setRegionId(String regionId) {
        this.regionId = regionId;
        return this;
    }
    public String getRegionId() {
        return this.regionId;
    }

    public GetVillageOrgInfoResponseBody setRegionLocation(String regionLocation) {
        this.regionLocation = regionLocation;
        return this;
    }
    public String getRegionLocation() {
        return this.regionLocation;
    }

    public GetVillageOrgInfoResponseBody setRegionType(String regionType) {
        this.regionType = regionType;
        return this;
    }
    public String getRegionType() {
        return this.regionType;
    }

}
