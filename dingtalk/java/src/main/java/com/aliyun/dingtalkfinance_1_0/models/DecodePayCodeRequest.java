// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class DecodePayCodeRequest extends TeaModel {
    @NameInMap("payCode")
    public String payCode;

    @NameInMap("requestId")
    public String requestId;

    public static DecodePayCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        DecodePayCodeRequest self = new DecodePayCodeRequest();
        return TeaModel.build(map, self);
    }

    public DecodePayCodeRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public DecodePayCodeRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
