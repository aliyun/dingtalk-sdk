// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetDisableRequest extends TeaModel {
    // userId
    @NameInMap("userId")
    public String userId;

    // reason
    @NameInMap("reason")
    public String reason;

    public static SetDisableRequest build(java.util.Map<String, ?> map) throws Exception {
        SetDisableRequest self = new SetDisableRequest();
        return TeaModel.build(map, self);
    }

    public SetDisableRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public SetDisableRequest setReason(String reason) {
        this.reason = reason;
        return this;
    }
    public String getReason() {
        return this.reason;
    }

}
