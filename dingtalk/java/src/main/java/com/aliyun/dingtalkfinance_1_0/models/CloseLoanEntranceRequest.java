// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CloseLoanEntranceRequest extends TeaModel {
    /**
     * <p>请求id唯一</p>
     */
    @NameInMap("requestId")
    public String requestId;

    public static CloseLoanEntranceRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseLoanEntranceRequest self = new CloseLoanEntranceRequest();
        return TeaModel.build(map, self);
    }

    public CloseLoanEntranceRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
