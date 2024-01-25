// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpStatisticDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCorpStatisticDataResponseBody body;

    public static QueryCorpStatisticDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpStatisticDataResponse self = new QueryCorpStatisticDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCorpStatisticDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCorpStatisticDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCorpStatisticDataResponse setBody(QueryCorpStatisticDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCorpStatisticDataResponseBody getBody() {
        return this.body;
    }

}
