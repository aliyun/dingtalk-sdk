// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryMedicalEventsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryMedicalEventsResponse setBody(QueryMedicalEventsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMedicalEventsResponseBody getBody() {
        return this.body;
    }

}
