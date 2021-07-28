// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateInterviewSignInInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpdateInterviewSignInInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInterviewSignInInfoResponse self = new UpdateInterviewSignInInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInterviewSignInInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
