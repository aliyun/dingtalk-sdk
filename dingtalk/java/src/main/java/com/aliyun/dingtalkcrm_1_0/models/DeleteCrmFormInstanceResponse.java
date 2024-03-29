// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmFormInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCrmFormInstanceResponseBody body;

    public static DeleteCrmFormInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmFormInstanceResponse self = new DeleteCrmFormInstanceResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCrmFormInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCrmFormInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCrmFormInstanceResponse setBody(DeleteCrmFormInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCrmFormInstanceResponseBody getBody() {
        return this.body;
    }

}
