// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeRemoveStudentRequest extends TeaModel {
    /**
     * <p>部门id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>学生id</p>
     */
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
