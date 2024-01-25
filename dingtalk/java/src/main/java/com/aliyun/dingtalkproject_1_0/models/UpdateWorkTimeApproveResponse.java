// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateWorkTimeApproveResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateWorkTimeApproveResponseBody body;

    public static UpdateWorkTimeApproveResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateWorkTimeApproveResponse self = new UpdateWorkTimeApproveResponse();
        return TeaModel.build(map, self);
    }

    public UpdateWorkTimeApproveResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateWorkTimeApproveResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateWorkTimeApproveResponse setBody(UpdateWorkTimeApproveResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateWorkTimeApproveResponseBody getBody() {
        return this.body;
    }

}
