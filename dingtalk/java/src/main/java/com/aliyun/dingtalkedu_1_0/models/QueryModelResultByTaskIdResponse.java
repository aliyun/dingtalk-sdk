// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryModelResultByTaskIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryModelResultByTaskIdResponseBody body;

    public static QueryModelResultByTaskIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryModelResultByTaskIdResponse self = new QueryModelResultByTaskIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryModelResultByTaskIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryModelResultByTaskIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryModelResultByTaskIdResponse setBody(QueryModelResultByTaskIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryModelResultByTaskIdResponseBody getBody() {
        return this.body;
    }

}
