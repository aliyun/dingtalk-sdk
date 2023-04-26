// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSeriousViolationResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetSeriousViolationResponseBody body;

    public static GetSeriousViolationResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSeriousViolationResponse self = new GetSeriousViolationResponse();
        return TeaModel.build(map, self);
    }

    public GetSeriousViolationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSeriousViolationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSeriousViolationResponse setBody(GetSeriousViolationResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSeriousViolationResponseBody getBody() {
        return this.body;
    }

}
