// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreNodeInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreNodeInfoResponseBody body;

    public static DigitalStoreNodeInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreNodeInfoResponse self = new DigitalStoreNodeInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreNodeInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreNodeInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreNodeInfoResponse setBody(DigitalStoreNodeInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreNodeInfoResponseBody getBody() {
        return this.body;
    }

}
