// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateTeacherCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchCreateTeacherCourseResponseBody body;

    public static BatchCreateTeacherCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateTeacherCourseResponse self = new BatchCreateTeacherCourseResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateTeacherCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateTeacherCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchCreateTeacherCourseResponse setBody(BatchCreateTeacherCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateTeacherCourseResponseBody getBody() {
        return this.body;
    }

}
