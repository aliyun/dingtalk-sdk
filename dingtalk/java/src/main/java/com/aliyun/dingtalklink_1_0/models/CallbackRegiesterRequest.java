// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CallbackRegiesterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3b89df4dfaaccd5b8e1f9a2</p>
     */
    @NameInMap("apiSecret")
    public String apiSecret;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abc-123</p>
     */
    @NameInMap("callbackKey")
    public String callbackKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://www.your.com/callback">https://www.your.com/callback</a></p>
     */
    @NameInMap("callbackUrl")
    public String callbackUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>shortcut</p>
     */
    @NameInMap("type")
    public String type;

    public static CallbackRegiesterRequest build(java.util.Map<String, ?> map) throws Exception {
        CallbackRegiesterRequest self = new CallbackRegiesterRequest();
        return TeaModel.build(map, self);
    }

    public CallbackRegiesterRequest setApiSecret(String apiSecret) {
        this.apiSecret = apiSecret;
        return this;
    }
    public String getApiSecret() {
        return this.apiSecret;
    }

    public CallbackRegiesterRequest setCallbackKey(String callbackKey) {
        this.callbackKey = callbackKey;
        return this;
    }
    public String getCallbackKey() {
        return this.callbackKey;
    }

    public CallbackRegiesterRequest setCallbackUrl(String callbackUrl) {
        this.callbackUrl = callbackUrl;
        return this;
    }
    public String getCallbackUrl() {
        return this.callbackUrl;
    }

    public CallbackRegiesterRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
