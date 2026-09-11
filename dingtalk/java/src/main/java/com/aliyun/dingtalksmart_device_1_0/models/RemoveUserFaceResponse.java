// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class RemoveUserFaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveUserFaceResponseBody body;

    public static RemoveUserFaceResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveUserFaceResponse self = new RemoveUserFaceResponse();
        return TeaModel.build(map, self);
    }

    public RemoveUserFaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveUserFaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveUserFaceResponse setBody(RemoveUserFaceResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveUserFaceResponseBody getBody() {
        return this.body;
    }

}
