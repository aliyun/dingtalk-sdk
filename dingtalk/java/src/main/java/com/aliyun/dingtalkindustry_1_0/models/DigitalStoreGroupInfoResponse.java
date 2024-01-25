// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreGroupInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreGroupInfoResponseBody body;

    public static DigitalStoreGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreGroupInfoResponse self = new DigitalStoreGroupInfoResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreGroupInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreGroupInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreGroupInfoResponse setBody(DigitalStoreGroupInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreGroupInfoResponseBody getBody() {
        return this.body;
    }

}
