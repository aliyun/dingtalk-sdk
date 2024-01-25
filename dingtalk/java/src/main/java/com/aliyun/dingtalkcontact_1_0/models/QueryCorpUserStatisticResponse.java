// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpUserStatisticResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCorpUserStatisticResponseBody body;

    public static QueryCorpUserStatisticResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpUserStatisticResponse self = new QueryCorpUserStatisticResponse();
        return TeaModel.build(map, self);
    }

    public QueryCorpUserStatisticResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCorpUserStatisticResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCorpUserStatisticResponse setBody(QueryCorpUserStatisticResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCorpUserStatisticResponseBody getBody() {
        return this.body;
    }

}
