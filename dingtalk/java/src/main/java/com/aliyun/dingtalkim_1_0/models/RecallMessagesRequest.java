// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RecallMessagesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidc4iLyQBuHFQRvzxznz204Q</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openTaskId")
    public String openTaskId;

    public static RecallMessagesRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallMessagesRequest self = new RecallMessagesRequest();
        return TeaModel.build(map, self);
    }

    public RecallMessagesRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RecallMessagesRequest setOpenTaskId(String openTaskId) {
        this.openTaskId = openTaskId;
        return this;
    }
    public String getOpenTaskId() {
        return this.openTaskId;
    }

}
