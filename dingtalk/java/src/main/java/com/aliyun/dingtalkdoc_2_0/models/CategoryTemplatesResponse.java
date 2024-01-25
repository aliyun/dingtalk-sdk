// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CategoryTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CategoryTemplatesResponseBody body;

    public static CategoryTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        CategoryTemplatesResponse self = new CategoryTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public CategoryTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CategoryTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CategoryTemplatesResponse setBody(CategoryTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public CategoryTemplatesResponseBody getBody() {
        return this.body;
    }

}
