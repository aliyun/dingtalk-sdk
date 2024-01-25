// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryAllSubjectsFromClassScheduleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllSubjectsFromClassScheduleResponseBody body;

    public static QueryAllSubjectsFromClassScheduleResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllSubjectsFromClassScheduleResponse self = new QueryAllSubjectsFromClassScheduleResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllSubjectsFromClassScheduleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllSubjectsFromClassScheduleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllSubjectsFromClassScheduleResponse setBody(QueryAllSubjectsFromClassScheduleResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllSubjectsFromClassScheduleResponseBody getBody() {
        return this.body;
    }

}
