// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ApplyFollowerAuthInfoRequest extends TeaModel {
    @NameInMap("appAuthKey")
    public String appAuthKey;

    /**
     * <strong>example:</strong>
     * <p>Contact.User.mobile</p>
     */
    @NameInMap("fieldScope")
    public String fieldScope;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sid22b31b4bf59ef2c783f7</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>idzb26bxl64vqx2keyi</p>
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
