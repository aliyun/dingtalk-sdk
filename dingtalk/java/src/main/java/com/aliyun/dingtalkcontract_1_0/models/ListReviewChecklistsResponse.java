// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class ListReviewChecklistsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListReviewChecklistsResponseBody body;

    public static ListReviewChecklistsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListReviewChecklistsResponse self = new ListReviewChecklistsResponse();
        return TeaModel.build(map, self);
    }

    public ListReviewChecklistsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListReviewChecklistsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListReviewChecklistsResponse setBody(ListReviewChecklistsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListReviewChecklistsResponseBody getBody() {
        return this.body;
    }

}
