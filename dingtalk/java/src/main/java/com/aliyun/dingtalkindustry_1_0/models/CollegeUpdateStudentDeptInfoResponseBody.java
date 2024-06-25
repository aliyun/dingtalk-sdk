// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentDeptInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeUpdateStudentDeptInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentDeptInfoResponseBody self = new CollegeUpdateStudentDeptInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentDeptInfoResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
