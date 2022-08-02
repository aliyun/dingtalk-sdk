// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryCollegeDeptInfoRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    public static CollegeQueryCollegeDeptInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryCollegeDeptInfoRequest self = new CollegeQueryCollegeDeptInfoRequest();
        return TeaModel.build(map, self);
    }

    public CollegeQueryCollegeDeptInfoRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
