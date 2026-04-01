// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class EditGroupBlackboardRequest extends TeaModel {
    @NameInMap("content")
    public String content;

    @NameInMap("dataId")
    public String dataId;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("sticky")
    public Boolean sticky;

    @NameInMap("userId")
    public String userId;

    public static EditGroupBlackboardRequest build(java.util.Map<String, ?> map) throws Exception {
        EditGroupBlackboardRequest self = new EditGroupBlackboardRequest();
        return TeaModel.build(map, self);
    }

    public EditGroupBlackboardRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public EditGroupBlackboardRequest setDataId(String dataId) {
        this.dataId = dataId;
        return this;
    }
    public String getDataId() {
        return this.dataId;
    }

    public EditGroupBlackboardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public EditGroupBlackboardRequest setSticky(Boolean sticky) {
        this.sticky = sticky;
        return this;
    }
    public Boolean getSticky() {
        return this.sticky;
    }

    public EditGroupBlackboardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
