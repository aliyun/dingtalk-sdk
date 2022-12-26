// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SendContractCardResponseBody extends TeaModel {
    // 成功
    @NameInMap("success")
    public Boolean success;

    public static SendContractCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendContractCardResponseBody self = new SendContractCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendContractCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
