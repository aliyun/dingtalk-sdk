// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ApplyFollowerAuthInfoRequest extends TeaModel {
    // 申请的授权数据，多个数据时使用,分隔。
    // 暂时仅支持申请手机号码授权：Contact.User.mobile
    @NameInMap("fieldScope")
    public String fieldScope;

    // 服务窗机器人消息sessionId。
    // 开发者需要接入服务窗自建机器人后通过回调消息获取到的sessionId。
    @NameInMap("sessionId")
    public String sessionId;

    // 服务窗关注用户userId。
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
