// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeActiveCollegeDeptGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11111</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    public static CollegeActiveCollegeDeptGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeActiveCollegeDeptGroupRequest self = new CollegeActiveCollegeDeptGroupRequest();
        return TeaModel.build(map, self);
    }

    public CollegeActiveCollegeDeptGroupRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
