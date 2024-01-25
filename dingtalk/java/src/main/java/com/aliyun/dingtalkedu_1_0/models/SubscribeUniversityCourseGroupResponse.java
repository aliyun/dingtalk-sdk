// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SubscribeUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubscribeUniversityCourseGroupResponseBody body;

    public static SubscribeUniversityCourseGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        SubscribeUniversityCourseGroupResponse self = new SubscribeUniversityCourseGroupResponse();
        return TeaModel.build(map, self);
    }

    public SubscribeUniversityCourseGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubscribeUniversityCourseGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubscribeUniversityCourseGroupResponse setBody(SubscribeUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public SubscribeUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
