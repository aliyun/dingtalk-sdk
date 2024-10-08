// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryFlashMinutesSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryFlashMinutesSummaryResponseBody body;

    public static QueryFlashMinutesSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryFlashMinutesSummaryResponse self = new QueryFlashMinutesSummaryResponse();
        return TeaModel.build(map, self);
    }

    public QueryFlashMinutesSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryFlashMinutesSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryFlashMinutesSummaryResponse setBody(QueryFlashMinutesSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryFlashMinutesSummaryResponseBody getBody() {
        return this.body;
    }

}
