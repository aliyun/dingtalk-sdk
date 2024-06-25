// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetInstanceByIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxyy</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetInstanceByIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInstanceByIdRequest self = new GetInstanceByIdRequest();
        return TeaModel.build(map, self);
    }

    public GetInstanceByIdRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetInstanceByIdRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetInstanceByIdRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetInstanceByIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
