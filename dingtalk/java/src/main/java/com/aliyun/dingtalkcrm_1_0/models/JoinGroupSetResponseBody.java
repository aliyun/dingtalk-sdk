// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class JoinGroupSetResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abc123</p>
     */
    @NameInMap("chatId")
    public String chatId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abc123</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static JoinGroupSetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        JoinGroupSetResponseBody self = new JoinGroupSetResponseBody();
        return TeaModel.build(map, self);
    }

    public JoinGroupSetResponseBody setChatId(String chatId) {
        this.chatId = chatId;
        return this;
    }
    public String getChatId() {
        return this.chatId;
    }

    public JoinGroupSetResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
