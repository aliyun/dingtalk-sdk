// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchCreateCourseResponseBody body;

    public static BatchCreateCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateCourseResponse self = new BatchCreateCourseResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchCreateCourseResponse setBody(BatchCreateCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateCourseResponseBody getBody() {
        return this.body;
    }

}
