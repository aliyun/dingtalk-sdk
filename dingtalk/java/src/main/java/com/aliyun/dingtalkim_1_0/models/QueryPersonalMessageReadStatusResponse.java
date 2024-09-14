// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryPersonalMessageReadStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPersonalMessageReadStatusResponseBody body;

    public static QueryPersonalMessageReadStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPersonalMessageReadStatusResponse self = new QueryPersonalMessageReadStatusResponse();
        return TeaModel.build(map, self);
    }

    public QueryPersonalMessageReadStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPersonalMessageReadStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPersonalMessageReadStatusResponse setBody(QueryPersonalMessageReadStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPersonalMessageReadStatusResponseBody getBody() {
        return this.body;
    }

}
