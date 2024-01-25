// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SyncDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncDataResponseBody body;

    public static SyncDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncDataResponse self = new SyncDataResponse();
        return TeaModel.build(map, self);
    }

    public SyncDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncDataResponse setBody(SyncDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncDataResponseBody getBody() {
        return this.body;
    }

}
