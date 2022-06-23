// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class AssignOrgHoldingToEmpHoldingBatchResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AssignOrgHoldingToEmpHoldingBatchResponseBody body;

    public static AssignOrgHoldingToEmpHoldingBatchResponse build(java.util.Map<String, ?> map) throws Exception {
        AssignOrgHoldingToEmpHoldingBatchResponse self = new AssignOrgHoldingToEmpHoldingBatchResponse();
        return TeaModel.build(map, self);
    }

    public AssignOrgHoldingToEmpHoldingBatchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AssignOrgHoldingToEmpHoldingBatchResponse setBody(AssignOrgHoldingToEmpHoldingBatchResponseBody body) {
        this.body = body;
        return this;
    }
    public AssignOrgHoldingToEmpHoldingBatchResponseBody getBody() {
        return this.body;
    }

}
