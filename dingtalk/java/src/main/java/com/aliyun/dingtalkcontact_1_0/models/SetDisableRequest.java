// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetDisableRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>reasonYYY</p>
     */
    @NameInMap("reason")
    public String reason;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userIdXXX</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SetDisableRequest build(java.util.Map<String, ?> map) throws Exception {
        SetDisableRequest self = new SetDisableRequest();
        return TeaModel.build(map, self);
    }

    public SetDisableRequest setReason(String reason) {
        this.reason = reason;
        return this;
    }
    public String getReason() {
        return this.reason;
    }

    public SetDisableRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
