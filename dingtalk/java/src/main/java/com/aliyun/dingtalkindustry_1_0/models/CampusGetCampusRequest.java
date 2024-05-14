// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetCampusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("campusDeptId")
    public Long campusDeptId;

    public static CampusGetCampusRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusGetCampusRequest self = new CampusGetCampusRequest();
        return TeaModel.build(map, self);
    }

    public CampusGetCampusRequest setCampusDeptId(Long campusDeptId) {
        this.campusDeptId = campusDeptId;
        return this;
    }
    public Long getCampusDeptId() {
        return this.campusDeptId;
    }

}
