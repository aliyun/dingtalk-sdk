// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDetailDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetConfDetailDataResponseBody body;

    public static GetConfDetailDataResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConfDetailDataResponse self = new GetConfDetailDataResponse();
        return TeaModel.build(map, self);
    }

    public GetConfDetailDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConfDetailDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConfDetailDataResponse setBody(GetConfDetailDataResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConfDetailDataResponseBody getBody() {
        return this.body;
    }

}
