// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CollegeListDeptManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CollegeListDeptManagerResponseBody body;

    public static CollegeListDeptManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        CollegeListDeptManagerResponse self = new CollegeListDeptManagerResponse();
        return TeaModel.build(map, self);
    }

    public CollegeListDeptManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollegeListDeptManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollegeListDeptManagerResponse setBody(CollegeListDeptManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public CollegeListDeptManagerResponseBody getBody() {
        return this.body;
    }

}
