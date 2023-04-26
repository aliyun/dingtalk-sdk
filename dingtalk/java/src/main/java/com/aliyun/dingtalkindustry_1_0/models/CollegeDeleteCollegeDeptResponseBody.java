// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeDeleteCollegeDeptResponseBody extends TeaModel {
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeDeleteCollegeDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeDeleteCollegeDeptResponseBody self = new CollegeDeleteCollegeDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeDeleteCollegeDeptResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
