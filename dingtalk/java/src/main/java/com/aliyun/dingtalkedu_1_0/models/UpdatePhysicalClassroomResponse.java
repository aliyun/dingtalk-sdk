// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdatePhysicalClassroomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdatePhysicalClassroomResponseBody body;

    public static UpdatePhysicalClassroomResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdatePhysicalClassroomResponse self = new UpdatePhysicalClassroomResponse();
        return TeaModel.build(map, self);
    }

    public UpdatePhysicalClassroomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdatePhysicalClassroomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdatePhysicalClassroomResponse setBody(UpdatePhysicalClassroomResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdatePhysicalClassroomResponseBody getBody() {
        return this.body;
    }

}
