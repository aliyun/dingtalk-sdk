// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryScheduleConfSettingsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryScheduleConfSettingsResponseBody body;

    public static QueryScheduleConfSettingsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryScheduleConfSettingsResponse self = new QueryScheduleConfSettingsResponse();
        return TeaModel.build(map, self);
    }

    public QueryScheduleConfSettingsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryScheduleConfSettingsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryScheduleConfSettingsResponse setBody(QueryScheduleConfSettingsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryScheduleConfSettingsResponseBody getBody() {
        return this.body;
    }

}
