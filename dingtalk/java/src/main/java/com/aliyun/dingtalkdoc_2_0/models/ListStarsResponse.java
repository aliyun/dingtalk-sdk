// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListStarsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListStarsResponseBody body;

    public static ListStarsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListStarsResponse self = new ListStarsResponse();
        return TeaModel.build(map, self);
    }

    public ListStarsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListStarsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListStarsResponse setBody(ListStarsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListStarsResponseBody getBody() {
        return this.body;
    }

}
