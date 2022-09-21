// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ApplyFollowerAuthInfoRequest extends TeaModel {
    // 申请的授权数据，多个数据时使用,分隔
    @NameInMap("fieldScope")
    public String fieldScope;

    // 客服会话sessionId
    @NameInMap("sessionId")
    public String sessionId;

    // 用户信息
    @NameInMap("userId")
    public String userId;

    public static ApplyFollowerAuthInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        ApplyFollowerAuthInfoRequest self = new ApplyFollowerAuthInfoRequest();
        return TeaModel.build(map, self);
    }

    public ApplyFollowerAuthInfoRequest setFieldScope(String fieldScope) {
        this.fieldScope = fieldScope;
        return this;
    }
    public String getFieldScope() {
        return this.fieldScope;
    }

    public ApplyFollowerAuthInfoRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

    public ApplyFollowerAuthInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
