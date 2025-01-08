// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryPaymentRecallFileRequest extends TeaModel {
    @NameInMap("detailIdList")
    public java.util.List<String> detailIdList;

    @NameInMap("operator")
    public String operator;

    public static BatchQueryPaymentRecallFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryPaymentRecallFileRequest self = new BatchQueryPaymentRecallFileRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryPaymentRecallFileRequest setDetailIdList(java.util.List<String> detailIdList) {
        this.detailIdList = detailIdList;
        return this;
    }
    public java.util.List<String> getDetailIdList() {
        return this.detailIdList;
    }

    public BatchQueryPaymentRecallFileRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
