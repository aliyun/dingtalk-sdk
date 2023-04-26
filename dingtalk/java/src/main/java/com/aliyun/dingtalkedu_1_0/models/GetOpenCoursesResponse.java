// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetOpenCoursesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetOpenCoursesResponseBody body;

    public static GetOpenCoursesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOpenCoursesResponse self = new GetOpenCoursesResponse();
        return TeaModel.build(map, self);
    }

    public GetOpenCoursesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOpenCoursesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOpenCoursesResponse setBody(GetOpenCoursesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOpenCoursesResponseBody getBody() {
        return this.body;
    }

}
