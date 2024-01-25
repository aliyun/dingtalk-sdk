// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CourseSchedulingComplimentNoticeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CourseSchedulingComplimentNoticeResponseBody body;

    public static CourseSchedulingComplimentNoticeResponse build(java.util.Map<String, ?> map) throws Exception {
        CourseSchedulingComplimentNoticeResponse self = new CourseSchedulingComplimentNoticeResponse();
        return TeaModel.build(map, self);
    }

    public CourseSchedulingComplimentNoticeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CourseSchedulingComplimentNoticeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CourseSchedulingComplimentNoticeResponse setBody(CourseSchedulingComplimentNoticeResponseBody body) {
        this.body = body;
        return this;
    }
    public CourseSchedulingComplimentNoticeResponseBody getBody() {
        return this.body;
    }

}
