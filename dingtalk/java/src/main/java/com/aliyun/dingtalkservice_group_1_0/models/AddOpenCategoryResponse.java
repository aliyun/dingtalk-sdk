// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public AddOpenCategoryResponse setBody(AddOpenCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public AddOpenCategoryResponseBody getBody() {
        return this.body;
    }

}
