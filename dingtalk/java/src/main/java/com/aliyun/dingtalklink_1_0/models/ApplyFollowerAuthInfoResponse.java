// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ApplyFollowerAuthInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ApplyFollowerAuthInfoResponseBody body;

    public static ApplyFollowerAuthInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        ApplyFollowerAuthInfoResponse self = new ApplyFollowerAuthInfoResponse();
        return TeaModel.build(map, self);
    }

    public ApplyFollowerAuthInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ApplyFollowerAuthInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ApplyFollowerAuthInfoResponse setBody(ApplyFollowerAuthInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public ApplyFollowerAuthInfoResponseBody getBody() {
        return this.body;
    }

}
