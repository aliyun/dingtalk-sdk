// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRecentsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListRecentsResponseBody body;

    public static ListRecentsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListRecentsResponse self = new ListRecentsResponse();
        return TeaModel.build(map, self);
    }

    public ListRecentsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListRecentsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListRecentsResponse setBody(ListRecentsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRecentsResponseBody getBody() {
        return this.body;
    }

}
