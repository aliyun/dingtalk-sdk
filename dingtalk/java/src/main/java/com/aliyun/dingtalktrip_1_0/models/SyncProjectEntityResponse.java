// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncProjectEntityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncProjectEntityResponseBody body;

    public static SyncProjectEntityResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncProjectEntityResponse self = new SyncProjectEntityResponse();
        return TeaModel.build(map, self);
    }

    public SyncProjectEntityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncProjectEntityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncProjectEntityResponse setBody(SyncProjectEntityResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncProjectEntityResponseBody getBody() {
        return this.body;
    }

}
