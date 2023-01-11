// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class RegisterCallbackRequest extends TeaModel {
    /**
     * <p>加密密钥用于校验来源</p>
     */
    @NameInMap("apiSecret")
    public String apiSecret;

    /**
     * <p>callbackUrl 的路由 Key，一个 callbackRouteKey 可以映射一个 callbackUrl</p>
     */
    @NameInMap("callbackRouteKey")
    public String callbackRouteKey;

    /**
     * <p>注册的回调 URL</p>
     */
    @NameInMap("callbackUrl")
    public String callbackUrl;

    /**
     * <p>是否强制覆盖更新，默认 false</p>
     */
    @NameInMap("forceUpdate")
    public Boolean forceUpdate;

    public static RegisterCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterCallbackRequest self = new RegisterCallbackRequest();
        return TeaModel.build(map, self);
    }

    public RegisterCallbackRequest setApiSecret(String apiSecret) {
        this.apiSecret = apiSecret;
        return this;
    }
    public String getApiSecret() {
        return this.apiSecret;
    }

    public RegisterCallbackRequest setCallbackRouteKey(String callbackRouteKey) {
        this.callbackRouteKey = callbackRouteKey;
        return this;
    }
    public String getCallbackRouteKey() {
        return this.callbackRouteKey;
    }

    public RegisterCallbackRequest setCallbackUrl(String callbackUrl) {
        this.callbackUrl = callbackUrl;
        return this;
    }
    public String getCallbackUrl() {
        return this.callbackUrl;
    }

    public RegisterCallbackRequest setForceUpdate(Boolean forceUpdate) {
        this.forceUpdate = forceUpdate;
        return this;
    }
    public Boolean getForceUpdate() {
        return this.forceUpdate;
    }

}
