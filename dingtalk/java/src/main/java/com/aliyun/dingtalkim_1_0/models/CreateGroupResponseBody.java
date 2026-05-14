// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupResponseBody extends TeaModel {
    /**
     * <p>群会话Id</p>
     */
    @NameInMap("chatid")
    public String chatid;

    /**
     * <p>会话类型标记</p>
     */
    @NameInMap("conversationTag")
    public Long conversationTag;

    /**
     * <p>开放群会话Id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static CreateGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupResponseBody self = new CreateGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateGroupResponseBody setChatid(String chatid) {
        this.chatid = chatid;
        return this;
    }
    public String getChatid() {
        return this.chatid;
    }

    public CreateGroupResponseBody setConversationTag(Long conversationTag) {
        this.conversationTag = conversationTag;
        return this;
    }
    public Long getConversationTag() {
        return this.conversationTag;
    }

    public CreateGroupResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
