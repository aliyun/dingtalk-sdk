// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddOpenCategoryResponseBody body;

    public static AddOpenCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        AddOpenCategoryResponse self = new AddOpenCategoryResponse();
        return TeaModel.build(map, self);
    }

    public AddOpenCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddOpenCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddOpenCategoryResponse setBody(AddOpenCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOpenCategoryResponseBody getBody() {
        return this.body;
    }

}
