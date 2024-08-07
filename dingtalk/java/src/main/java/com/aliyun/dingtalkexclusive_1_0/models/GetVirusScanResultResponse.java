// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetVirusScanResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetVirusScanResultResponseBody body;

    public static GetVirusScanResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetVirusScanResultResponse self = new GetVirusScanResultResponse();
        return TeaModel.build(map, self);
    }

    public GetVirusScanResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetVirusScanResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetVirusScanResultResponse setBody(GetVirusScanResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetVirusScanResultResponseBody getBody() {
        return this.body;
    }

}
