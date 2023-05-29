// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class WorkbenchTransformInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public WorkbenchTransformInfoResponseBody body;

    public static WorkbenchTransformInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        WorkbenchTransformInfoResponse self = new WorkbenchTransformInfoResponse();
        return TeaModel.build(map, self);
    }

    public WorkbenchTransformInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WorkbenchTransformInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WorkbenchTransformInfoResponse setBody(WorkbenchTransformInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public WorkbenchTransformInfoResponseBody getBody() {
        return this.body;
    }

}
