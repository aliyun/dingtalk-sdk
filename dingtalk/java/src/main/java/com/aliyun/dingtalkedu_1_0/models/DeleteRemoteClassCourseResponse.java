// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteRemoteClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteRemoteClassCourseResponseBody body;

    public static DeleteRemoteClassCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRemoteClassCourseResponse self = new DeleteRemoteClassCourseResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRemoteClassCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRemoteClassCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteRemoteClassCourseResponse setBody(DeleteRemoteClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRemoteClassCourseResponseBody getBody() {
        return this.body;
    }

}
