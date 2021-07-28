// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassScheduleByTimeSchoolResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryClassScheduleByTimeSchoolResponseBody body;

    public static QueryClassScheduleByTimeSchoolResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryClassScheduleByTimeSchoolResponse self = new QueryClassScheduleByTimeSchoolResponse();
        return TeaModel.build(map, self);
    }

    public QueryClassScheduleByTimeSchoolResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryClassScheduleByTimeSchoolResponse setBody(QueryClassScheduleByTimeSchoolResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryClassScheduleByTimeSchoolResponseBody getBody() {
        return this.body;
    }

}
