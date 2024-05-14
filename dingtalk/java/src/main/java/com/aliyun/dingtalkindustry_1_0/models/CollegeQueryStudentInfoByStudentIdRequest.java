// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeQueryStudentInfoByStudentIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("studentId")
    public Long studentId;

    public static CollegeQueryStudentInfoByStudentIdRequest build(java.util.Map<String, ?> map) throws Exception {
        CollegeQueryStudentInfoByStudentIdRequest self = new CollegeQueryStudentInfoByStudentIdRequest();
        return TeaModel.build(map, self);
    }

    public CollegeQueryStudentInfoByStudentIdRequest setStudentId(Long studentId) {
        this.studentId = studentId;
        return this;
    }
    public Long getStudentId() {
        return this.studentId;
    }

}
