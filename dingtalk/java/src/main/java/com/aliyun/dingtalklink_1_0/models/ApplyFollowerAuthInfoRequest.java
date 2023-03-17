// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ApplyFollowerAuthInfoRequest extends TeaModel {
    /**
     * <p>应用授权Key,可通过服务窗开放互联功能获取。此参数与fieldScope参数二选一。</p>
     */
    @NameInMap("appAuthKey")
    public String appAuthKey;

    /**
     * <p>申请的授权数据，多个数据时使用,分隔。此参数与appAuthKey参数二选一。</p>
     * <p>暂时仅支持申请手机号码授权：Contact.User.mobile</p>
     */
    @NameInMap("fieldScope")
    public String fieldScope;

    /**
     * <p>服务窗机器人消息sessionId。</p>
     * <p>开发者需要接入服务窗自建机器人后通过回调消息获取到的sessionId。</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    /**
     * <p>服务窗关注用户userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ApplyFollowerAuthInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        ApplyFollowerAuthInfoRequest self = new ApplyFollowerAuthInfoRequest();
        return TeaModel.build(map, self);
    }

    public ApplyFollowerAuthInfoRequest setAppAuthKey(String appAuthKey) {
        this.appAuthKey = appAuthKey;
        return this;
    }
    public String getAppAuthKey() {
        return this.appAuthKey;
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
