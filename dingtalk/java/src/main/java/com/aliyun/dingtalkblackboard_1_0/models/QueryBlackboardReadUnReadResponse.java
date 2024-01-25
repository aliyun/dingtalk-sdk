// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkblackboard_1_0.models;

import com.aliyun.tea.*;

public class QueryBlackboardReadUnReadResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBlackboardReadUnReadResponseBody body;

    public static QueryBlackboardReadUnReadResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBlackboardReadUnReadResponse self = new QueryBlackboardReadUnReadResponse();
        return TeaModel.build(map, self);
    }

    public QueryBlackboardReadUnReadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBlackboardReadUnReadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBlackboardReadUnReadResponse setBody(QueryBlackboardReadUnReadResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBlackboardReadUnReadResponseBody getBody() {
        return this.body;
    }

}
