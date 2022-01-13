// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatSingleResponseBody extends TeaModel {
    // 客户群chatId
    @NameInMap("chatId")
    public String chatId;

    // corpId。
    @NameInMap("corpId")
    public String corpId;

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

    public static GetCrmGroupChatSingleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatSingleResponseBody self = new GetCrmGroupChatSingleResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatSingleResponseBody setChatId(String chatId) {
        this.chatId = chatId;
        return this;
    }
    public String getChatId() {
        return this.chatId;
    }

    public GetCrmGroupChatSingleResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetCrmGroupChatSingleResponseBody setGmtCreate(Long gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public Long getGmtCreate() {
        return this.gmtCreate;
    }

    public GetCrmGroupChatSingleResponseBody setIconUrl(String iconUrl) {
        this.iconUrl = iconUrl;
        return this;
    }
    public String getIconUrl() {
        return this.iconUrl;
    }

    public GetCrmGroupChatSingleResponseBody setMemberCount(Integer memberCount) {
        this.memberCount = memberCount;
        return this;
    }
    public Integer getMemberCount() {
        return this.memberCount;
    }

    public GetCrmGroupChatSingleResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCrmGroupChatSingleResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetCrmGroupChatSingleResponseBody setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public GetCrmGroupChatSingleResponseBody setOwnerUserId(String ownerUserId) {
        this.ownerUserId = ownerUserId;
        return this;
    }
    public String getOwnerUserId() {
        return this.ownerUserId;
    }

    public GetCrmGroupChatSingleResponseBody setOwnerUserName(String ownerUserName) {
        this.ownerUserName = ownerUserName;
        return this;
    }
    public String getOwnerUserName() {
        return this.ownerUserName;
    }

}
