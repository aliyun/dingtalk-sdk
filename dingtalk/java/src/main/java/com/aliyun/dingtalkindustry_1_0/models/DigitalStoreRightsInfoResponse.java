// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreRightsInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreRightsInfoResponseBody body;

    public static DigitalStoreRightsInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreRightsInfoResponse self = new DigitalStoreRightsInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreRightsInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreRightsInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreRightsInfoResponse setBody(DigitalStoreRightsInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreRightsInfoResponseBody getBody() {
        return this.body;
    }

}
