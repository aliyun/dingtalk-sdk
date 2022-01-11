// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatResponseBody extends TeaModel {
    // 客户群chatId
    @NameInMap("chatId")
    public String chatId;

    // 创建时间(时间戳)
    @NameInMap("gmtCreate")
    public Long gmtCreate;

    // 群头像地址
    @NameInMap("iconUrl")
    public String iconUrl;

    // 客户群成员数
    @NameInMap("memberCount")
    public Integer memberCount;

    // 客户群名
    @NameInMap("name")
    public String name;

    // 客户群openConversationId
    @NameInMap("openConversationId")
    public String openConversationId;

    // 群组openGroupSetId
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    // 群主userId
    @NameInMap("ownerUserId")
    public String ownerUserId;

    // 群主userName
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
