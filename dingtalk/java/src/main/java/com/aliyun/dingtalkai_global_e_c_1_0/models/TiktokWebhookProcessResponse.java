// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class TiktokWebhookProcessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TiktokWebhookProcessResponseBody body;

    public static TiktokWebhookProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        TiktokWebhookProcessResponse self = new TiktokWebhookProcessResponse();
        return TeaModel.build(map, self);
    }

    public TiktokWebhookProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TiktokWebhookProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TiktokWebhookProcessResponse setBody(TiktokWebhookProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public TiktokWebhookProcessResponseBody getBody() {
        return this.body;
    }

}
