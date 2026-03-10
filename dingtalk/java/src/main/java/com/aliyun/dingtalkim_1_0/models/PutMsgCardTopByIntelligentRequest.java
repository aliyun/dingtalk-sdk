// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class PutMsgCardTopByIntelligentRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidt*****Xa4K10w==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openTaskId")
    public String openTaskId;

    public static PutMsgCardTopByIntelligentRequest build(java.util.Map<String, ?> map) throws Exception {
        PutMsgCardTopByIntelligentRequest self = new PutMsgCardTopByIntelligentRequest();
        return TeaModel.build(map, self);
    }

    public PutMsgCardTopByIntelligentRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public PutMsgCardTopByIntelligentRequest setOpenTaskId(String openTaskId) {
        this.openTaskId = openTaskId;
        return this;
    }
    public String getOpenTaskId() {
        return this.openTaskId;
    }

}
