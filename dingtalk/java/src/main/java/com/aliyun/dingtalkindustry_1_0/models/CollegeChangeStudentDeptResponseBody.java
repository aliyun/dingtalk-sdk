// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeChangeStudentDeptResponseBody extends TeaModel {
    // 转移组织是否成功
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeChangeStudentDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeChangeStudentDeptResponseBody self = new CollegeChangeStudentDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeChangeStudentDeptResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
