// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CheckUserIsGroupMemberRequest extends TeaModel {
    /**
     * <p>会话id。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>用户userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CheckUserIsGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckUserIsGroupMemberRequest self = new CheckUserIsGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public CheckUserIsGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CheckUserIsGroupMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
