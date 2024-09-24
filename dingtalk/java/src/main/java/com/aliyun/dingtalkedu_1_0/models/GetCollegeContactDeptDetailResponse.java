// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeContactDeptDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCollegeContactDeptDetailResponseBody body;

    public static GetCollegeContactDeptDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeContactDeptDetailResponse self = new GetCollegeContactDeptDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetCollegeContactDeptDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCollegeContactDeptDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCollegeContactDeptDetailResponse setBody(GetCollegeContactDeptDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCollegeContactDeptDetailResponseBody getBody() {
        return this.body;
    }

}
