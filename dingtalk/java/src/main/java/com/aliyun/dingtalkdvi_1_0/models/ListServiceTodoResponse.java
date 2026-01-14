// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListServiceTodoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListServiceTodoResponseBody body;

    public static ListServiceTodoResponse build(java.util.Map<String, ?> map) throws Exception {
        ListServiceTodoResponse self = new ListServiceTodoResponse();
        return TeaModel.build(map, self);
    }

    public ListServiceTodoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListServiceTodoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListServiceTodoResponse setBody(ListServiceTodoResponseBody body) {
        this.body = body;
        return this;
    }
    public ListServiceTodoResponseBody getBody() {
        return this.body;
    }

}
