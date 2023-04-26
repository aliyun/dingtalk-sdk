// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UnsubscribeUniversityCourseGroupResponseBody body;

    public static UnsubscribeUniversityCourseGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        UnsubscribeUniversityCourseGroupResponse self = new UnsubscribeUniversityCourseGroupResponse();
        return TeaModel.build(map, self);
    }

    public UnsubscribeUniversityCourseGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UnsubscribeUniversityCourseGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UnsubscribeUniversityCourseGroupResponse setBody(UnsubscribeUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public UnsubscribeUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
