// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeChangeStudentDeptRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>11111</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>222222</p>
     */
    @NameInMap("newDeptId")
    public Long newDeptId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33333</p>
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
