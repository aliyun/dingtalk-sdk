// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreUpdateAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreUpdateAuthInfoResponseBody body;

    public static DigitalStoreUpdateAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreUpdateAuthInfoResponse self = new DigitalStoreUpdateAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreUpdateAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreUpdateAuthInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreUpdateAuthInfoResponse setBody(DigitalStoreUpdateAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreUpdateAuthInfoResponseBody getBody() {
        return this.body;
    }

}
