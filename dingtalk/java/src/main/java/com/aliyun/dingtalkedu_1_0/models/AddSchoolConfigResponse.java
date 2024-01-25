// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddSchoolConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddSchoolConfigResponseBody body;

    public static AddSchoolConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        AddSchoolConfigResponse self = new AddSchoolConfigResponse();
        return TeaModel.build(map, self);
    }

    public AddSchoolConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddSchoolConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddSchoolConfigResponse setBody(AddSchoolConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public AddSchoolConfigResponseBody getBody() {
        return this.body;
    }

}
