// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CancelConsumeResponseBody extends TeaModel {
    @NameInMap("result")
    public CancelConsumeResponseBodyResult result;

    public static CancelConsumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelConsumeResponseBody self = new CancelConsumeResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelConsumeResponseBody setResult(CancelConsumeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CancelConsumeResponseBodyResult getResult() {
        return this.result;
    }

    public static class CancelConsumeResponseBodyResult extends TeaModel {
        @NameInMap("isSuccess")
        public Boolean isSuccess;

        public static CancelConsumeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CancelConsumeResponseBodyResult self = new CancelConsumeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CancelConsumeResponseBodyResult setIsSuccess(Boolean isSuccess) {
            this.isSuccess = isSuccess;
            return this;
        }
        public Boolean getIsSuccess() {
            return this.isSuccess;
        }

    }

}
