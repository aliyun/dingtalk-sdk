// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConfMinutesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryScheduleConfMinutesResponseBody body;

    public static QueryScheduleConfMinutesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConfMinutesResponse self = new QueryScheduleConfMinutesResponse();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConfMinutesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryScheduleConfMinutesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryScheduleConfMinutesResponse setBody(QueryScheduleConfMinutesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryScheduleConfMinutesResponseBody getBody() {
        return this.body;
    }

}
