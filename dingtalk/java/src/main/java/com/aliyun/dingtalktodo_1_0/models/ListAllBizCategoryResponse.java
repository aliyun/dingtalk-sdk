// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class ListAllBizCategoryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListAllBizCategoryResponseBody body;

    public static ListAllBizCategoryResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAllBizCategoryResponse self = new ListAllBizCategoryResponse();
        return TeaModel.build(map, self);
    }

    public ListAllBizCategoryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAllBizCategoryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAllBizCategoryResponse setBody(ListAllBizCategoryResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAllBizCategoryResponseBody getBody() {
        return this.body;
    }

}
