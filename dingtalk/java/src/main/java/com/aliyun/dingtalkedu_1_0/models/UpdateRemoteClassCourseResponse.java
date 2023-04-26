// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateRemoteClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateRemoteClassCourseResponseBody body;

    public static UpdateRemoteClassCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRemoteClassCourseResponse self = new UpdateRemoteClassCourseResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRemoteClassCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRemoteClassCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRemoteClassCourseResponse setBody(UpdateRemoteClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRemoteClassCourseResponseBody getBody() {
        return this.body;
    }

}
