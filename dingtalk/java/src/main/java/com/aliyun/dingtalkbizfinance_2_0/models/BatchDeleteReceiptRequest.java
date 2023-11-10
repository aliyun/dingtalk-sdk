// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteReceiptRequest extends TeaModel {
    @NameInMap("instanceIdList")
    public java.util.List<String> instanceIdList;

    @NameInMap("operator")
    public String operator;

    public static BatchDeleteReceiptRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteReceiptRequest self = new BatchDeleteReceiptRequest();
        return TeaModel.build(map, self);
    }

    public BatchDeleteReceiptRequest setInstanceIdList(java.util.List<String> instanceIdList) {
        this.instanceIdList = instanceIdList;
        return this;
    }
    public java.util.List<String> getInstanceIdList() {
        return this.instanceIdList;
    }

    public BatchDeleteReceiptRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
