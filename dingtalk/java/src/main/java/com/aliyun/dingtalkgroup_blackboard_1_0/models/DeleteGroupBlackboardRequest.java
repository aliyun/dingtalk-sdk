// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupBlackboardRequest extends TeaModel {
    @NameInMap("dataId")
    public String dataId;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("userId")
    public String userId;

    public static DeleteGroupBlackboardRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupBlackboardRequest self = new DeleteGroupBlackboardRequest();
        return TeaModel.build(map, self);
    }

    public DeleteGroupBlackboardRequest setDataId(String dataId) {
        this.dataId = dataId;
        return this;
    }
    public String getDataId() {
        return this.dataId;
    }

    public DeleteGroupBlackboardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public DeleteGroupBlackboardRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
