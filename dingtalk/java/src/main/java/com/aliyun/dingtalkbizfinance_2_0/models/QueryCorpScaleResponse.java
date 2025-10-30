// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryCorpScaleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCorpScaleResponseBody body;

    public static QueryCorpScaleResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpScaleResponse self = new QueryCorpScaleResponse();
        return TeaModel.build(map, self);
    }

    public QueryCorpScaleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCorpScaleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCorpScaleResponse setBody(QueryCorpScaleResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCorpScaleResponseBody getBody() {
        return this.body;
    }

}
