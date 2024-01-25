// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreConversationsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreConversationsResponseBody body;

    public static DigitalStoreConversationsResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreConversationsResponse self = new DigitalStoreConversationsResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreConversationsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreConversationsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreConversationsResponse setBody(DigitalStoreConversationsResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreConversationsResponseBody getBody() {
        return this.body;
    }

}
