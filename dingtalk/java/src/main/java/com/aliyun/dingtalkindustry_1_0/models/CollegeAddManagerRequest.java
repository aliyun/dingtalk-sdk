// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddManagerRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    // userId
    @NameInMap("userId")
    public String userId;

    public static CollegeAddManagerRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddManagerRequest self = new CollegeAddManagerRequest();
        return TeaModel.build(map, self);
    }

    public CollegeAddManagerRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeAddManagerRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
