// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceIgnoreStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <strong>example:</strong>
     * <p>IGNORE</p>
     */
    @NameInMap("status")
    public String status;

    public static UpdateInvoiceIgnoreStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceIgnoreStatusRequest self = new UpdateInvoiceIgnoreStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceIgnoreStatusRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public UpdateInvoiceIgnoreStatusRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateInvoiceIgnoreStatusRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
