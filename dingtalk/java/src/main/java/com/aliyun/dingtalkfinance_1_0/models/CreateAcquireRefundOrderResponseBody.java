// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateAcquireRefundOrderResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>r2021113000001</p>
     */
    @NameInMap("outRefundNo")
    public String outRefundNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202111110000111</p>
     */
    @NameInMap("refundOrderNo")
    public String refundOrderNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("status")
    public String status;

    public static CreateAcquireRefundOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAcquireRefundOrderResponseBody self = new CreateAcquireRefundOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAcquireRefundOrderResponseBody setOutRefundNo(String outRefundNo) {
        this.outRefundNo = outRefundNo;
        return this;
    }
    public String getOutRefundNo() {
        return this.outRefundNo;
    }

    public CreateAcquireRefundOrderResponseBody setRefundOrderNo(String refundOrderNo) {
        this.refundOrderNo = refundOrderNo;
        return this;
    }
    public String getRefundOrderNo() {
        return this.refundOrderNo;
    }

    public CreateAcquireRefundOrderResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
