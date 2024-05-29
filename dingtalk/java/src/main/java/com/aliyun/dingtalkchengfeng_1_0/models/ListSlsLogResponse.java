// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListSlsLogResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSlsLogResponseBody body;

    public static ListSlsLogResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSlsLogResponse self = new ListSlsLogResponse();
        return TeaModel.build(map, self);
    }

    public ListSlsLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSlsLogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSlsLogResponse setBody(ListSlsLogResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSlsLogResponseBody getBody() {
        return this.body;
    }

}
