// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncProjectResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncProjectResponseBody body;

    public static SyncProjectResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncProjectResponse self = new SyncProjectResponse();
        return TeaModel.build(map, self);
    }

    public SyncProjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncProjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncProjectResponse setBody(SyncProjectResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncProjectResponseBody getBody() {
        return this.body;
    }

}
