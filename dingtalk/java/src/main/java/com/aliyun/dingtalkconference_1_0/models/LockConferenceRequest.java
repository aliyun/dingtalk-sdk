// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class LockConferenceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("action")
    public String action;

    public static LockConferenceRequest build(java.util.Map<String, ?> map) throws Exception {
        LockConferenceRequest self = new LockConferenceRequest();
        return TeaModel.build(map, self);
    }

    public LockConferenceRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

}
