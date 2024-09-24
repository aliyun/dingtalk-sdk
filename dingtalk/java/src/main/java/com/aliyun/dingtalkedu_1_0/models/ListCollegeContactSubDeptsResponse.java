// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ListCollegeContactSubDeptsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListCollegeContactSubDeptsResponseBody body;

    public static ListCollegeContactSubDeptsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListCollegeContactSubDeptsResponse self = new ListCollegeContactSubDeptsResponse();
        return TeaModel.build(map, self);
    }

    public ListCollegeContactSubDeptsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListCollegeContactSubDeptsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListCollegeContactSubDeptsResponse setBody(ListCollegeContactSubDeptsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListCollegeContactSubDeptsResponseBody getBody() {
        return this.body;
    }

}
