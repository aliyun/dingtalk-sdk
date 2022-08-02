// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeRemoveManagerRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    // 是否强制移除
    @NameInMap("isForce")
    public Boolean isForce;

    // userId
    @NameInMap("userId")
    public String userId;

    public static CollegeRemoveManagerRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeRemoveManagerRequest self = new CollegeRemoveManagerRequest();
        return TeaModel.build(map, self);
    }

    public CollegeRemoveManagerRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeRemoveManagerRequest setIsForce(Boolean isForce) {
        this.isForce = isForce;
        return this;
    }
    public Boolean getIsForce() {
        return this.isForce;
    }

    public CollegeRemoveManagerRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
