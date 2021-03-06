// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryClassScheduleResponseBody body;

    public static QueryClassScheduleResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleResponse self = new QueryClassScheduleResponse();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryClassScheduleResponse setBody(QueryClassScheduleResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryClassScheduleResponseBody getBody() {
        return this.body;
    }

}
