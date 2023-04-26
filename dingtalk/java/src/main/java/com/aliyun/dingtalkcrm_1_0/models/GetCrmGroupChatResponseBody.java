// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatResponseBody extends TeaModel {
    @NameInMap("chatId")
    public String chatId;

    @NameInMap("gmtCreate")
    public Long gmtCreate;

    @NameInMap("iconUrl")
    public String iconUrl;

    @NameInMap("memberCount")
    public Integer memberCount;

    @NameInMap("name")
    public String name;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    @NameInMap("ownerUserId")
    public String ownerUserId;

    @NameInMap("ownerUserName")
    public String ownerUserName;

    public static GetCrmGroupChatResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatResponseBody self = new GetCrmGroupChatResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatResponseBody setChatId(String chatId) {
        this.chatId = chatId;
        return this;
    }
    public String getChatId() {
        return this.chatId;
    }

    public GetCrmGroupChatResponseBody setGmtCreate(Long gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public Long getGmtCreate() {
        return this.gmtCreate;
    }

    public GetCrmGroupChatResponseBody setIconUrl(String iconUrl) {
        this.iconUrl = iconUrl;
        return this;
    }
    public String getIconUrl() {
        return this.iconUrl;
    }

    public GetCrmGroupChatResponseBody setMemberCount(Integer memberCount) {
        this.memberCount = memberCount;
        return this;
    }
    public Integer getMemberCount() {
        return this.memberCount;
    }

    public GetCrmGroupChatResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCrmGroupChatResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetCrmGroupChatResponseBody setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public GetCrmGroupChatResponseBody setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public GetCrmGroupChatResponseBody setOwnerUserName(String ownerUserName) {
        this.ownerUserName = ownerUserName;
        return this;
    }
    public String getOwnerUserName() {
        return this.ownerUserName;
    }

}
