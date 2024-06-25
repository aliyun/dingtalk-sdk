// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SendPhoneDingResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SendPhoneDingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendPhoneDingResponseBody self = new SendPhoneDingResponseBody();
        return TeaModel.build(map, self);
    }

    public SendPhoneDingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
