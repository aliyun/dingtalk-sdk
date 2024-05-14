// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetEnableRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SetEnableRequest build(java.util.Map<String, ?> map) throws Exception {
        SetEnableRequest self = new SetEnableRequest();
        return TeaModel.build(map, self);
    }

    public SetEnableRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
