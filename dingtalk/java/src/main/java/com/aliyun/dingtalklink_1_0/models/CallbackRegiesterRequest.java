// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class CallbackRegiesterRequest extends TeaModel {
    /**
     * <p>回调API签名生成密钥。</p>
     * <p>最大长度不超过32个字符。</p>
     */
    @NameInMap("apiSecret")
    public String apiSecret;

    /**
     * <p>回调key，由调用者定义，需要确保同一服务窗帐号下的唯一性。</p>
     * <p>最长不超过32个字符。</p>
     */
    @NameInMap("callbackKey")
    public String callbackKey;

    /**
     * <p>回调URL。暂不支持附带queryString的URL</p>
     */
    @NameInMap("callbackUrl")
    public String callbackUrl;

    /**
     * <p>回调类型，支持互动卡片、应用快捷入口、吊顶卡片等。</p>
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
