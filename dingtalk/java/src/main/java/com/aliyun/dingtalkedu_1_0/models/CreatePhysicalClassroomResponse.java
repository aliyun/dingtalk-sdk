// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreatePhysicalClassroomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreatePhysicalClassroomResponseBody body;

    public static CreatePhysicalClassroomResponse build(java.util.Map<String, ?> map) throws Exception {
        CreatePhysicalClassroomResponse self = new CreatePhysicalClassroomResponse();
        return TeaModel.build(map, self);
    }

    public CreatePhysicalClassroomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreatePhysicalClassroomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreatePhysicalClassroomResponse setBody(CreatePhysicalClassroomResponseBody body) {
        this.body = body;
        return this;
    }
    public CreatePhysicalClassroomResponseBody getBody() {
        return this.body;
    }

}
