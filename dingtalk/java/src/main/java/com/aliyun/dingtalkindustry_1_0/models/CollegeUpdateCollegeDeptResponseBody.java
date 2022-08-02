// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeUpdateCollegeDeptResponseBody extends TeaModel {
    // 更新部门信息是否成功
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeUpdateCollegeDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeUpdateCollegeDeptResponseBody self = new CollegeUpdateCollegeDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeUpdateCollegeDeptResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
