// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SubscribeUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SubscribeUniversityCourseGroupResponse setBody(SubscribeUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public SubscribeUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
