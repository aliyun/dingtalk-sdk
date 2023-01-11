// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatSingleResponseBody extends TeaModel {
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
