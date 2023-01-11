// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatResponseBody extends TeaModel {
    /**
     * <p>客户群chatId</p>
     */
    @NameInMap("chatId")
    public String chatId;

    /**
     * <p>创建时间(时间戳)</p>
     */
    @NameInMap("gmtCreate")
    public Long gmtCreate;

    /**
     * <p>群头像地址</p>
     */
    @NameInMap("iconUrl")
    public String iconUrl;

    /**
     * <p>客户群成员数</p>
     */
    @NameInMap("memberCount")
    public Integer memberCount;

    /**
     * <p>客户群名</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>客户群openConversationId</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>群组openGroupSetId</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>群主userId</p>
     */
    @NameInMap("ownerUserId")
    public String ownerUserId;

    /**
     * <p>群主userName</p>
     */
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
