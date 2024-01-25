// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCategoryResponseBody body;

    public static GetCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCategoryResponse self = new GetCategoryResponse();
        return TeaModel.build(map, self);
    }

    public GetCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCategoryResponse setBody(GetCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCategoryResponseBody getBody() {
        return this.body;
    }

}
