// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateBranchAttributesInCooperateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

}
