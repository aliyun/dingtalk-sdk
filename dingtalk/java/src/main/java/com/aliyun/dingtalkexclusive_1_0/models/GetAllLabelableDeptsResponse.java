// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAllLabelableDeptsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetAllLabelableDeptsResponseBody body;

    public static GetAllLabelableDeptsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllLabelableDeptsResponse self = new GetAllLabelableDeptsResponse();
        return TeaModel.build(map, self);
    }

    public GetAllLabelableDeptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllLabelableDeptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAllLabelableDeptsResponse setBody(GetAllLabelableDeptsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllLabelableDeptsResponseBody getBody() {
        return this.body;
    }

}
