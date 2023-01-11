// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateStudentInfoResponseBody extends TeaModel {
    /**
     * <p>学生信息是否修改成功</p>
     */
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeUpdateStudentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateStudentInfoResponseBody self = new CollegeUpdateStudentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateStudentInfoResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
