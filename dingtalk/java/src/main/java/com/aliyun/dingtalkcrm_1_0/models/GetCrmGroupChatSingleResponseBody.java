// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatSingleResponseBody extends TeaModel {
    @NameInMap("gmtCreate")
    public Long gmtCreate;

    /**
     * <strong>example:</strong>
     * <p><a href="https://static/xx.com/xx.jpg">https://static/xx.com/xx.jpg</a></p>
     */
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

    public static GetCrmGroupChatSingleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatSingleResponseBody self = new GetCrmGroupChatSingleResponseBody();
        return TeaModel.build(map, self);
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
