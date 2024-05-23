// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetMsgLocationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openMsgId")
    public String openMsgId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetMsgLocationRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMsgLocationRequest self = new GetMsgLocationRequest();
        return TeaModel.build(map, self);
    }

    public GetMsgLocationRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetMsgLocationRequest setOpenMsgId(String openMsgId) {
        this.openMsgId = openMsgId;
        return this;
    }
    public String getOpenMsgId() {
        return this.openMsgId;
    }

    public GetMsgLocationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
