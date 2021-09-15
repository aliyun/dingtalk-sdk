// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCategoryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetCategoryResponse setBody(GetCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCategoryResponseBody getBody() {
        return this.body;
    }

}
