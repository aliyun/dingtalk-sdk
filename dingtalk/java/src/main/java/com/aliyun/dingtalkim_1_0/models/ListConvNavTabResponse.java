// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListConvNavTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListConvNavTabResponseBody body;

    public static ListConvNavTabResponse build(java.util.Map<String, ?> map) throws Exception {
        ListConvNavTabResponse self = new ListConvNavTabResponse();
        return TeaModel.build(map, self);
    }

    public ListConvNavTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListConvNavTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListConvNavTabResponse setBody(ListConvNavTabResponseBody body) {
        this.body = body;
        return this;
    }
    public ListConvNavTabResponseBody getBody() {
        return this.body;
    }

}
