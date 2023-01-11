// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupConversationResponseBody extends TeaModel {
    /**
     * <p>添加成功的钉外成员列表。</p>
     */
    @NameInMap("appUserIds")
    public java.util.List<String> appUserIds;

    /**
     * <p>钉钉群会话Id。</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    /**
     * <p>群会话Id。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>添加成功的钉内成员列表。</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateGroupConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupConversationResponseBody self = new CreateGroupConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateGroupConversationResponseBody setAppUserIds(java.util.List<String> appUserIds) {
        this.appUserIds = appUserIds;
        return this;
    }
    public java.util.List<String> getAppUserIds() {
        return this.appUserIds;
    }

    public CreateGroupConversationResponseBody setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public CreateGroupConversationResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CreateGroupConversationResponseBody setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
