// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesKeywordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesKeywordResponseBody body;

    public static QueryMinutesKeywordResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesKeywordResponse self = new QueryMinutesKeywordResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesKeywordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesKeywordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesKeywordResponse setBody(QueryMinutesKeywordResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesKeywordResponseBody getBody() {
        return this.body;
    }

}
