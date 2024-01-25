// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteDeviceOrgResponseBody body;

    public static DeleteDeviceOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceOrgResponse self = new DeleteDeviceOrgResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDeviceOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteDeviceOrgResponse setBody(DeleteDeviceOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDeviceOrgResponseBody getBody() {
        return this.body;
    }

}
