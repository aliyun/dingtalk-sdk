// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeRemoveStudentResponseBody extends TeaModel {
    /**
     * <p>移除学生是否成功</p>
     */
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeRemoveStudentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeRemoveStudentResponseBody self = new CollegeRemoveStudentResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeRemoveStudentResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
