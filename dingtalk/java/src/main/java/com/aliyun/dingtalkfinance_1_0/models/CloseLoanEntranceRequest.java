// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CloseLoanEntranceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1a23qdfa</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
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
