// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteRemoteClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteRemoteClassCourseResponse setBody(DeleteRemoteClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRemoteClassCourseResponseBody getBody() {
        return this.body;
    }

}
