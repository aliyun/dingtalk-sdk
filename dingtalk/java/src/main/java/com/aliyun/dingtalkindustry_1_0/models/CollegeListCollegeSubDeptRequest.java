// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListCollegeSubDeptRequest extends TeaModel {
    /**
     * <p>部门id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    public static CollegeListCollegeSubDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeListCollegeSubDeptRequest self = new CollegeListCollegeSubDeptRequest();
        return TeaModel.build(map, self);
    }

    public CollegeListCollegeSubDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
