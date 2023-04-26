// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptDetailForInvoiceRequest extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static QueryReceiptDetailForInvoiceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptDetailForInvoiceRequest self = new QueryReceiptDetailForInvoiceRequest();
        return TeaModel.build(map, self);
    }

    public QueryReceiptDetailForInvoiceRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
