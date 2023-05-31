// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupResponseBody extends TeaModel {
    @NameInMap("appUserIds")
    public java.util.List<String> appUserIds;

    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateCoupleGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupResponseBody self = new CreateCoupleGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupResponseBody setAppUserIds(java.util.List<String> appUserIds) {
        this.appUserIds = appUserIds;
        return this;
    }
    public java.util.List<String> getAppUserIds() {
        return this.appUserIds;
    }

    public CreateCoupleGroupResponseBody setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public CreateCoupleGroupResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CreateCoupleGroupResponseBody setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
