// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripProductConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SyncTripProductConfigResponseBody body;

    public static SyncTripProductConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncTripProductConfigResponse self = new SyncTripProductConfigResponse();
        return TeaModel.build(map, self);
    }

    public SyncTripProductConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SyncTripProductConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SyncTripProductConfigResponse setBody(SyncTripProductConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public SyncTripProductConfigResponseBody getBody() {
        return this.body;
    }

}
