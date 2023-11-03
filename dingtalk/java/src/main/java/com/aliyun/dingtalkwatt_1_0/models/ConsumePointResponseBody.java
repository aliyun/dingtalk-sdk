// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class ConsumePointResponseBody extends TeaModel {
    @NameInMap("result")
    public ConsumePointResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ConsumePointResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConsumePointResponseBody self = new ConsumePointResponseBody();
        return TeaModel.build(map, self);
    }

    public ConsumePointResponseBody setResult(ConsumePointResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ConsumePointResponseBodyResult getResult() {
        return this.result;
    }

    public ConsumePointResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ConsumePointResponseBodyResult extends TeaModel {
        @NameInMap("consumedPoints")
        public Long consumedPoints;

        public static ConsumePointResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ConsumePointResponseBodyResult self = new ConsumePointResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ConsumePointResponseBodyResult setConsumedPoints(Long consumedPoints) {
            this.consumedPoints = consumedPoints;
            return this;
        }
        public Long getConsumedPoints() {
            return this.consumedPoints;
        }

    }

}
