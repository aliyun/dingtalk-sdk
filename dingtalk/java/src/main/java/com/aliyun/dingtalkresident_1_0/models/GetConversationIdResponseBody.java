// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetConversationIdResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidAX+2NwjqR3Y81Sxic5jtag==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetConversationIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConversationIdResponseBody self = new GetConversationIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConversationIdResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
