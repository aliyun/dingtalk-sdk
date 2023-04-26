// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetRemoteClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetRemoteClassCourseResponseBody body;

    public static GetRemoteClassCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRemoteClassCourseResponse self = new GetRemoteClassCourseResponse();
        return TeaModel.build(map, self);
    }

    public GetRemoteClassCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRemoteClassCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRemoteClassCourseResponse setBody(GetRemoteClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRemoteClassCourseResponseBody getBody() {
        return this.body;
    }

}
