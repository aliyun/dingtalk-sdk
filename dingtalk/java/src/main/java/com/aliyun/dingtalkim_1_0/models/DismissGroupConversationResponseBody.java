// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DismissGroupConversationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>14da****2760</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static DismissGroupConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DismissGroupConversationResponseBody self = new DismissGroupConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public DismissGroupConversationResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
