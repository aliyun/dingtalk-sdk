// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SyncSignEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncSignEventResponseBody body;

    public static SyncSignEventResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncSignEventResponse self = new SyncSignEventResponse();
        return TeaModel.build(map, self);
    }

    public SyncSignEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncSignEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncSignEventResponse setBody(SyncSignEventResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncSignEventResponseBody getBody() {
        return this.body;
    }

}
