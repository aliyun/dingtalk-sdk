// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetConversationIdRequest extends TeaModel {
    @NameInMap("appUid")
    public String appUid;

    @NameInMap("userId")
    public String userId;

    public static GetConversationIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConversationIdRequest self = new GetConversationIdRequest();
        return TeaModel.build(map, self);
    }

    public GetConversationIdRequest setAppUid(String appUid) {
        this.appUid = appUid;
        return this;
    }
    public String getAppUid() {
        return this.appUid;
    }

    public GetConversationIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
