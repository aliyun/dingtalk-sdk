// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetJobPositionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetJobPositionResponseBody body;

    public static GetJobPositionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetJobPositionResponse self = new GetJobPositionResponse();
        return TeaModel.build(map, self);
    }

    public GetJobPositionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetJobPositionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetJobPositionResponse setBody(GetJobPositionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetJobPositionResponseBody getBody() {
        return this.body;
    }

}
