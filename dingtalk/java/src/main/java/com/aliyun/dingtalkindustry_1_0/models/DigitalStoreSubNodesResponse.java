// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSubNodesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DigitalStoreSubNodesResponseBody body;

    public static DigitalStoreSubNodesResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreSubNodesResponse self = new DigitalStoreSubNodesResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreSubNodesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreSubNodesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreSubNodesResponse setBody(DigitalStoreSubNodesResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreSubNodesResponseBody getBody() {
        return this.body;
    }

}
