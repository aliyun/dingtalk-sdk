// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class PreCreateGroupBillOrderResponseBody extends TeaModel {
    @NameInMap("result")
    public PreCreateGroupBillOrderResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static PreCreateGroupBillOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PreCreateGroupBillOrderResponseBody self = new PreCreateGroupBillOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public PreCreateGroupBillOrderResponseBody setResult(PreCreateGroupBillOrderResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PreCreateGroupBillOrderResponseBodyResult getResult() {
        return this.result;
    }

    public PreCreateGroupBillOrderResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PreCreateGroupBillOrderResponseBodyResult extends TeaModel {
        @NameInMap("orderNo")
        public String orderNo;

        public static PreCreateGroupBillOrderResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PreCreateGroupBillOrderResponseBodyResult self = new PreCreateGroupBillOrderResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PreCreateGroupBillOrderResponseBodyResult setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

    }

}
