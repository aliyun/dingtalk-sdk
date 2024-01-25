// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreStoreInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreStoreInfoResponseBody body;

    public static DigitalStoreStoreInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreStoreInfoResponse self = new DigitalStoreStoreInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreStoreInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreStoreInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreStoreInfoResponse setBody(DigitalStoreStoreInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreStoreInfoResponseBody getBody() {
        return this.body;
    }

}
