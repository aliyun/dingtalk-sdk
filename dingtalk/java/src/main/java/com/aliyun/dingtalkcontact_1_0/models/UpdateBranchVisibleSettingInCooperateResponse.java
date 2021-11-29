// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateBranchVisibleSettingInCooperateResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static UpdateBranchVisibleSettingInCooperateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateBranchVisibleSettingInCooperateResponse self = new UpdateBranchVisibleSettingInCooperateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateBranchVisibleSettingInCooperateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
