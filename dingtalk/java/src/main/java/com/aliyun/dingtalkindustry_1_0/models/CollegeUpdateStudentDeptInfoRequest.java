// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentDeptInfoRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("studentId")
    public Long studentId;

    @NameInMap("studentNumber")
    public String studentNumber;

    public static CollegeUpdateStudentDeptInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentDeptInfoRequest self = new CollegeUpdateStudentDeptInfoRequest();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentDeptInfoRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeUpdateStudentDeptInfoRequest setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

    public CollegeUpdateStudentDeptInfoRequest setStudentNumber(String studentNumber) {
        this.studentNumber = studentNumber;
        return this;
    }
    public String getStudentNumber() {
        return this.studentNumber;
    }

}
