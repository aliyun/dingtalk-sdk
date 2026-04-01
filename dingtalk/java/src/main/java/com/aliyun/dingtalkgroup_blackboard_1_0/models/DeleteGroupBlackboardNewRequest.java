// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupBlackboardNewRequest extends TeaModel {
    @NameInMap("dataId")
    public String dataId;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("userId")
    public String userId;

    public static DeleteGroupBlackboardNewRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupBlackboardNewRequest self = new DeleteGroupBlackboardNewRequest();
        return TeaModel.build(map, self);
    }

    public DeleteGroupBlackboardNewRequest setDataId(String dataId) {
        this.dataId = dataId;
        return this;
    }
    public String getDataId() {
        return this.dataId;
    }

    public DeleteGroupBlackboardNewRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public DeleteGroupBlackboardNewRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
