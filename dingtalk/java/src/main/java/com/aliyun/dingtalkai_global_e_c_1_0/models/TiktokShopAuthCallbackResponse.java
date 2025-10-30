// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class TiktokShopAuthCallbackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TiktokShopAuthCallbackResponseBody body;

    public static TiktokShopAuthCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        TiktokShopAuthCallbackResponse self = new TiktokShopAuthCallbackResponse();
        return TeaModel.build(map, self);
    }

    public TiktokShopAuthCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TiktokShopAuthCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TiktokShopAuthCallbackResponse setBody(TiktokShopAuthCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public TiktokShopAuthCallbackResponseBody getBody() {
        return this.body;
    }

}
