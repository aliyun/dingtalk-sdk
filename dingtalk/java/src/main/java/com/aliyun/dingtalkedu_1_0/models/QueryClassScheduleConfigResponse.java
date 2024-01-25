// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryClassScheduleConfigResponseBody body;

    public static QueryClassScheduleConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleConfigResponse self = new QueryClassScheduleConfigResponse();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryClassScheduleConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryClassScheduleConfigResponse setBody(QueryClassScheduleConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryClassScheduleConfigResponseBody getBody() {
        return this.body;
    }

}
