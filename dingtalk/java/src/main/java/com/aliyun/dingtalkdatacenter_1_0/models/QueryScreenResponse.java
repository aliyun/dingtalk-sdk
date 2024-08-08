// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryScreenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryScreenResponseBody body;

    public static QueryScreenResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryScreenResponse self = new QueryScreenResponse();
        return TeaModel.build(map, self);
    }

    public QueryScreenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryScreenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryScreenResponse setBody(QueryScreenResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryScreenResponseBody getBody() {
        return this.body;
    }

}
