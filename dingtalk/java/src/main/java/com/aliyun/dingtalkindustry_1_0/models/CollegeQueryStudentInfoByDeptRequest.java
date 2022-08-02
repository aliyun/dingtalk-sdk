// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByDeptRequest extends TeaModel {
    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    // 学生id
    @NameInMap("studentId")
    public Long studentId;

    public static CollegeQueryStudentInfoByDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByDeptRequest self = new CollegeQueryStudentInfoByDeptRequest();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeQueryStudentInfoByDeptRequest setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

}
