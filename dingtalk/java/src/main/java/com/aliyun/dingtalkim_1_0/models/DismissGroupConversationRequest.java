// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DismissGroupConversationRequest extends TeaModel {
    /**
     * <p>群id(客联系业务系统内的群id)</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static DismissGroupConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        DismissGroupConversationRequest self = new DismissGroupConversationRequest();
        return TeaModel.build(map, self);
    }

    public DismissGroupConversationRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
