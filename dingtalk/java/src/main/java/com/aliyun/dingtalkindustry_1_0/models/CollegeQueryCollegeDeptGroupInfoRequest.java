// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryCollegeDeptGroupInfoRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    public static CollegeQueryCollegeDeptGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryCollegeDeptGroupInfoRequest self = new CollegeQueryCollegeDeptGroupInfoRequest();
        return TeaModel.build(map, self);
    }

    public CollegeQueryCollegeDeptGroupInfoRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
