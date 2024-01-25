// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateBranchAttributesInCooperateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    public static UpdateBranchAttributesInCooperateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateBranchAttributesInCooperateResponse self = new UpdateBranchAttributesInCooperateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateBranchAttributesInCooperateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateBranchAttributesInCooperateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

}
