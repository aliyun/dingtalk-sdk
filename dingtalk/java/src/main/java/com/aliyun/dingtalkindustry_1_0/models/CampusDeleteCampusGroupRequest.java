// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDeleteCampusGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("campusProjectGroupId")
    public Long campusProjectGroupId;

    public static CampusDeleteCampusGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusDeleteCampusGroupRequest self = new CampusDeleteCampusGroupRequest();
        return TeaModel.build(map, self);
    }

    public CampusDeleteCampusGroupRequest setCampusProjectGroupId(Long campusProjectGroupId) {
        this.campusProjectGroupId = campusProjectGroupId;
        return this;
    }
    public Long getCampusProjectGroupId() {
        return this.campusProjectGroupId;
    }

}
