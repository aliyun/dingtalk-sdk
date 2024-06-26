// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusGetCampusGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    public static CampusGetCampusGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusGetCampusGroupRequest self = new CampusGetCampusGroupRequest();
        return TeaModel.build(map, self);
    }

    public CampusGetCampusGroupRequest setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

}
