// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreContactInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreContactInfoResponseBody body;

    public static DigitalStoreContactInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreContactInfoResponse self = new DigitalStoreContactInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreContactInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreContactInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreContactInfoResponse setBody(DigitalStoreContactInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreContactInfoResponseBody getBody() {
        return this.body;
    }

}
