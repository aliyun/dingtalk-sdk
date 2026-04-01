// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupBlackboardNewRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("sendDing")
    public Boolean sendDing;

    @NameInMap("sticky")
    public Boolean sticky;

    @NameInMap("uniqueId")
    public String uniqueId;

    @NameInMap("userId")
    public String userId;

    public static CreateGroupBlackboardNewRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupBlackboardNewRequest self = new CreateGroupBlackboardNewRequest();
        return TeaModel.build(map, self);
    }

    public CreateGroupBlackboardNewRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateGroupBlackboardNewRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CreateGroupBlackboardNewRequest setSendDing(Boolean sendDing) {
        this.sendDing = sendDing;
        return this;
    }
    public Boolean getSendDing() {
        return this.sendDing;
    }

    public CreateGroupBlackboardNewRequest setSticky(Boolean sticky) {
        this.sticky = sticky;
        return this;
    }
    public Boolean getSticky() {
        return this.sticky;
    }

    public CreateGroupBlackboardNewRequest setUniqueId(String uniqueId) {
        this.uniqueId = uniqueId;
        return this;
    }
    public String getUniqueId() {
        return this.uniqueId;
    }

    public CreateGroupBlackboardNewRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
