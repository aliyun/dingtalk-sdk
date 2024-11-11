// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AdjustCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AdjustCourseResponseBody body;

    public static AdjustCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        AdjustCourseResponse self = new AdjustCourseResponse();
        return TeaModel.build(map, self);
    }

    public AdjustCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AdjustCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AdjustCourseResponse setBody(AdjustCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public AdjustCourseResponseBody getBody() {
        return this.body;
    }

}
