// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListGroupSetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListGroupSetResponseBody body;

    public static ListGroupSetResponse build(java.util.Map<String, ?> map) throws Exception {
        ListGroupSetResponse self = new ListGroupSetResponse();
        return TeaModel.build(map, self);
    }

    public ListGroupSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListGroupSetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListGroupSetResponse setBody(ListGroupSetResponseBody body) {
        this.body = body;
        return this;
    }
    public ListGroupSetResponseBody getBody() {
        return this.body;
    }

}
