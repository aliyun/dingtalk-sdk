// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeRemoveStudentRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    // 学生id
    @NameInMap("studentId")
    public Long studentId;

    public static CollegeRemoveStudentRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeRemoveStudentRequest self = new CollegeRemoveStudentRequest();
        return TeaModel.build(map, self);
    }

    public CollegeRemoveStudentRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeRemoveStudentRequest setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

}
