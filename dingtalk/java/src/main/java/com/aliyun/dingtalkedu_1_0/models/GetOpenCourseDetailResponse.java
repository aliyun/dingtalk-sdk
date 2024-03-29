// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetOpenCourseDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOpenCourseDetailResponseBody body;

    public static GetOpenCourseDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOpenCourseDetailResponse self = new GetOpenCourseDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetOpenCourseDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOpenCourseDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOpenCourseDetailResponse setBody(GetOpenCourseDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOpenCourseDetailResponseBody getBody() {
        return this.body;
    }

}
