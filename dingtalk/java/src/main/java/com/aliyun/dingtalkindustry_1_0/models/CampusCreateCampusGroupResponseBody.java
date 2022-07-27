// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusCreateCampusGroupResponseBody extends TeaModel {
    @NameInMap("groupId")
    public Long groupId;

    public static CampusCreateCampusGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusCreateCampusGroupResponseBody self = new CampusCreateCampusGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusCreateCampusGroupResponseBody setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

}
