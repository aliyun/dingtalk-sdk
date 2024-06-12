// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class GetAllFieldsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAllFieldsResponseBody body;

    public static GetAllFieldsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllFieldsResponse self = new GetAllFieldsResponse();
        return TeaModel.build(map, self);
    }

    public GetAllFieldsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllFieldsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAllFieldsResponse setBody(GetAllFieldsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllFieldsResponseBody getBody() {
        return this.body;
    }

}
