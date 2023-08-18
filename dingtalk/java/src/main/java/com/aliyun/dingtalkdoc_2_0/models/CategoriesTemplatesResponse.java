// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CategoriesTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CategoriesTemplatesResponseBody body;

    public static CategoriesTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        CategoriesTemplatesResponse self = new CategoriesTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public CategoriesTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CategoriesTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CategoriesTemplatesResponse setBody(CategoriesTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public CategoriesTemplatesResponseBody getBody() {
        return this.body;
    }

}
