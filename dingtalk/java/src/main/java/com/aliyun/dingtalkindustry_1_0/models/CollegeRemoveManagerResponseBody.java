// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeRemoveManagerResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isSuccessful")
    public Boolean isSuccessful;

    public static CollegeRemoveManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CollegeRemoveManagerResponseBody self = new CollegeRemoveManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public CollegeRemoveManagerResponseBody setIsSuccessful(Boolean isSuccessful) {
        this.isSuccessful = isSuccessful;
        return this;
    }
    public Boolean getIsSuccessful() {
        return this.isSuccessful;
    }

}
