// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreQueryConversationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreQueryConversationResponseBody body;

    public static DigitalStoreQueryConversationResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreQueryConversationResponse self = new DigitalStoreQueryConversationResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreQueryConversationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreQueryConversationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreQueryConversationResponse setBody(DigitalStoreQueryConversationResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreQueryConversationResponseBody getBody() {
        return this.body;
    }

}
