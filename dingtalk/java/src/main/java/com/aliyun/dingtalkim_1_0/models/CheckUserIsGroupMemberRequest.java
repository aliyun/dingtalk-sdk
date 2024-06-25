// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CheckUserIsGroupMemberRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidD2y*****==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>015*****</p>
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
