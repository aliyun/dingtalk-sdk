// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListFeedsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListFeedsResponseBody body;

    public static ListFeedsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListFeedsResponse self = new ListFeedsResponse();
        return TeaModel.build(map, self);
    }

    public ListFeedsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListFeedsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListFeedsResponse setBody(ListFeedsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListFeedsResponseBody getBody() {
        return this.body;
    }

}
