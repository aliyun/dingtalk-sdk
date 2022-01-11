// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetConversationIdRequest extends TeaModel {
    // 外部用户账号：outerId@channel
    @NameInMap("appUid")
    public String appUid;

    // 员工企业账号：staffId#corpId@dingding
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
