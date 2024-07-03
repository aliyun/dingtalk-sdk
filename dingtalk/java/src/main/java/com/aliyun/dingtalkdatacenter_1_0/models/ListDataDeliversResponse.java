// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class ListDataDeliversResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListDataDeliversResponseBody body;

    public static ListDataDeliversResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDataDeliversResponse self = new ListDataDeliversResponse();
        return TeaModel.build(map, self);
    }

    public ListDataDeliversResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDataDeliversResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListDataDeliversResponse setBody(ListDataDeliversResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDataDeliversResponseBody getBody() {
        return this.body;
    }

}
