// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ConsumeUserPointsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public ConsumeUserPointsResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>4990</p>
         */
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
