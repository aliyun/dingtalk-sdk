// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeDeleteCollegeDeptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11111</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    public static CollegeDeleteCollegeDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeDeleteCollegeDeptRequest self = new CollegeDeleteCollegeDeptRequest();
        return TeaModel.build(map, self);
    }

    public CollegeDeleteCollegeDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
