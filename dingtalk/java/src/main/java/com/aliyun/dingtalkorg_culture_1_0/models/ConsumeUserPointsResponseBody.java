// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ConsumeUserPointsResponseBody extends TeaModel {
    // 响应数据
    @NameInMap("result")
    public ConsumeUserPointsResponseBodyResult result;

    // 请求响应状态
    @NameInMap("success")
    public Boolean success;

    public static ConsumeUserPointsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConsumeUserPointsResponseBody self = new ConsumeUserPointsResponseBody();
        return TeaModel.build(map, self);
    }

    public ConsumeUserPointsResponseBody setResult(ConsumeUserPointsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ConsumeUserPointsResponseBodyResult getResult() {
        return this.result;
    }

    public ConsumeUserPointsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ConsumeUserPointsResponseBodyResult extends TeaModel {
        // 扣减后剩余积分数量
        @NameInMap("amount")
        public Long amount;

        public static ConsumeUserPointsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ConsumeUserPointsResponseBodyResult self = new ConsumeUserPointsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ConsumeUserPointsResponseBodyResult setAmount(Long amount) {
            this.amount = amount;
            return this;
        }
        public Long getAmount() {
            return this.amount;
        }

    }

}
