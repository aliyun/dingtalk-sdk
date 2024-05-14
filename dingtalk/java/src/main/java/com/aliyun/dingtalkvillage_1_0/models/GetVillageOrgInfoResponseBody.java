// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetVillageOrgInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("regionId")
    public String regionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("regionLocation")
    public String regionLocation;

    /**
     * <p>This parameter is required.</p>
     */
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
