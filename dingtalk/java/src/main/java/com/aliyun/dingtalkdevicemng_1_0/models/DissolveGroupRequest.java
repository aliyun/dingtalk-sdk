// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class DissolveGroupRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxxxxxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static DissolveGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        DissolveGroupRequest self = new DissolveGroupRequest();
        return TeaModel.build(map, self);
    }

    public DissolveGroupRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
