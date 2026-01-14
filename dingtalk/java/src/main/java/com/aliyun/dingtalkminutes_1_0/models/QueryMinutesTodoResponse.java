// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesTodoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesTodoResponseBody body;

    public static QueryMinutesTodoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesTodoResponse self = new QueryMinutesTodoResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesTodoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesTodoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesTodoResponse setBody(QueryMinutesTodoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesTodoResponseBody getBody() {
        return this.body;
    }

}
