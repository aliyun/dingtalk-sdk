// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUserInfoRequest extends TeaModel {
    /**
     * <p>门店通迅录Code</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>人员Id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DigitalStoreUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUserInfoRequest self = new DigitalStoreUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUserInfoRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DigitalStoreUserInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
