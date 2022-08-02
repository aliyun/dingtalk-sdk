// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeAddManagerResponseBody extends TeaModel {
    // 添加负责人是否成功
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeAddManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeAddManagerResponseBody self = new CollegeAddManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeAddManagerResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
