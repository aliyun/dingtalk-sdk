// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SignOutRequest extends TeaModel {
    @NameInMap("reason")
    public String reason;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SignOutRequest build(java.util.Map<String, ?> map) throws Exception {
        SignOutRequest self = new SignOutRequest();
        return TeaModel.build(map, self);
    }

    public SignOutRequest setReason(String reason) {
        this.reason = reason;
        return this;
    }
    public String getReason() {
        return this.reason;
    }

    public SignOutRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
