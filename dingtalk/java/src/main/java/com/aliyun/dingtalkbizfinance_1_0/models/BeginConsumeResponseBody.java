// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BeginConsumeResponseBody extends TeaModel {
    @NameInMap("result")
    public BeginConsumeResponseBodyResult result;

    public static BeginConsumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BeginConsumeResponseBody self = new BeginConsumeResponseBody();
        return TeaModel.build(map, self);
    }

    public BeginConsumeResponseBody setResult(BeginConsumeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BeginConsumeResponseBodyResult getResult() {
        return this.result;
    }

    public static class BeginConsumeResponseBodyResult extends TeaModel {
        @NameInMap("isSuccess")
        public Boolean isSuccess;

        public static BeginConsumeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BeginConsumeResponseBodyResult self = new BeginConsumeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BeginConsumeResponseBodyResult setIsSuccess(Boolean isSuccess) {
            this.isSuccess = isSuccess;
            return this;
        }
        public Boolean getIsSuccess() {
            return this.isSuccess;
        }

    }

}
