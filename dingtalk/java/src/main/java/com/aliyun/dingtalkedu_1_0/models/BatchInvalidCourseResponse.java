// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchInvalidCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchInvalidCourseResponseBody body;

    public static BatchInvalidCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchInvalidCourseResponse self = new BatchInvalidCourseResponse();
        return TeaModel.build(map, self);
    }

    public BatchInvalidCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchInvalidCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchInvalidCourseResponse setBody(BatchInvalidCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchInvalidCourseResponseBody getBody() {
        return this.body;
    }

}
