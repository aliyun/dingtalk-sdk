// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSceneScopeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DigitalStoreSceneScopeResponseBody body;

    public static DigitalStoreSceneScopeResponse build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreSceneScopeResponse self = new DigitalStoreSceneScopeResponse();
        return TeaModel.build(map, self);
    }

    public DigitalStoreSceneScopeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DigitalStoreSceneScopeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DigitalStoreSceneScopeResponse setBody(DigitalStoreSceneScopeResponseBody body) {
        this.body = body;
        return this;
    }
    public DigitalStoreSceneScopeResponseBody getBody() {
        return this.body;
    }

}
