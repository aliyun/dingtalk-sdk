// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TemplateCategoriesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TemplateCategoriesResponseBody body;

    public static TemplateCategoriesResponse build(java.util.Map<String, ?> map) throws Exception {
        TemplateCategoriesResponse self = new TemplateCategoriesResponse();
        return TeaModel.build(map, self);
    }

    public TemplateCategoriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TemplateCategoriesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TemplateCategoriesResponse setBody(TemplateCategoriesResponseBody body) {
        this.body = body;
        return this;
    }
    public TemplateCategoriesResponseBody getBody() {
        return this.body;
    }

}
