// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeChangeStudentDeptRequest extends TeaModel {
    /**
     * <p>部门id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>新部门id</p>
     */
    @NameInMap("newDeptId")
    public Long newDeptId;

    /**
     * <p>学生id</p>
     */
    @NameInMap("studentId")
    public Long studentId;

    public static CollegeChangeStudentDeptRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeChangeStudentDeptRequest self = new CollegeChangeStudentDeptRequest();
        return TeaModel.build(map, self);
    }

    public CollegeChangeStudentDeptRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CollegeChangeStudentDeptRequest setNewDeptId(Long newDeptId) {
        this.newDeptId = newDeptId;
        return this;
    }
    public Long getNewDeptId() {
        return this.newDeptId;
    }

    public CollegeChangeStudentDeptRequest setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

}
