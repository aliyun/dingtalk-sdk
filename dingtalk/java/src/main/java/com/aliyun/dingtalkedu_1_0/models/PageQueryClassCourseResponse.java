// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PageQueryClassCourseResponseBody body;

    public static PageQueryClassCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        PageQueryClassCourseResponse self = new PageQueryClassCourseResponse();
        return TeaModel.build(map, self);
    }

    public PageQueryClassCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageQueryClassCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageQueryClassCourseResponse setBody(PageQueryClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public PageQueryClassCourseResponseBody getBody() {
        return this.body;
    }

}
