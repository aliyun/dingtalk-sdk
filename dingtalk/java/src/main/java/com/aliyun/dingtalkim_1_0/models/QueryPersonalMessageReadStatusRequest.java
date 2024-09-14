// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryPersonalMessageReadStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidQGfKJCXMfVxZxxx3ZL0Qlw==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>msghnezLi8wb6pGqMsadhj9n0yw==</p>
     */
    @NameInMap("openMessageId")
    public String openMessageId;

    public static QueryPersonalMessageReadStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPersonalMessageReadStatusRequest self = new QueryPersonalMessageReadStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryPersonalMessageReadStatusRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public QueryPersonalMessageReadStatusRequest setOpenMessageId(String openMessageId) {
        this.openMessageId = openMessageId;
        return this;
    }
    public String getOpenMessageId() {
        return this.openMessageId;
    }

}
