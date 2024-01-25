// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryMedicalEventsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMedicalEventsResponseBody body;

    public static QueryMedicalEventsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMedicalEventsResponse self = new QueryMedicalEventsResponse();
        return TeaModel.build(map, self);
    }

    public QueryMedicalEventsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMedicalEventsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMedicalEventsResponse setBody(QueryMedicalEventsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMedicalEventsResponseBody getBody() {
        return this.body;
    }

}
