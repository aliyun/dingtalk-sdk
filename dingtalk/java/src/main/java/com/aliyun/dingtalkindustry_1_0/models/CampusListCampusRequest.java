// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusListCampusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>12345</p>
     */
    @NameInMap("groupDeptId")
    public Long groupDeptId;

    public static CampusListCampusRequest build(java.util.Map<String, ?> map) throws Exception {
        CampusListCampusRequest self = new CampusListCampusRequest();
        return TeaModel.build(map, self);
    }

    public CampusListCampusRequest setGroupDeptId(Long groupDeptId) {
        this.groupDeptId = groupDeptId;
        return this;
    }
    public Long getGroupDeptId() {
        return this.groupDeptId;
    }

}
