// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class SetBizCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetBizCategoryResponseBody body;

    public static SetBizCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        SetBizCategoryResponse self = new SetBizCategoryResponse();
        return TeaModel.build(map, self);
    }

    public SetBizCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetBizCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetBizCategoryResponse setBody(SetBizCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public SetBizCategoryResponseBody getBody() {
        return this.body;
    }

}
