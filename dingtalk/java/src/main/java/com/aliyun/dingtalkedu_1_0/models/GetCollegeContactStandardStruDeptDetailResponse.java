// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeContactStandardStruDeptDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCollegeContactStandardStruDeptDetailResponseBody body;

    public static GetCollegeContactStandardStruDeptDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeContactStandardStruDeptDetailResponse self = new GetCollegeContactStandardStruDeptDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetCollegeContactStandardStruDeptDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCollegeContactStandardStruDeptDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCollegeContactStandardStruDeptDetailResponse setBody(GetCollegeContactStandardStruDeptDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCollegeContactStandardStruDeptDetailResponseBody getBody() {
        return this.body;
    }

}
