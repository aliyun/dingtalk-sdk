// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CommitConsumeResponseBody extends TeaModel {
    @NameInMap("result")
    public CommitConsumeResponseBodyResult result;

    public static CommitConsumeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CommitConsumeResponseBody self = new CommitConsumeResponseBody();
        return TeaModel.build(map, self);
    }

    public CommitConsumeResponseBody setResult(CommitConsumeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CommitConsumeResponseBodyResult getResult() {
        return this.result;
    }

    public static class CommitConsumeResponseBodyResult extends TeaModel {
        @NameInMap("isSuccess")
        public Boolean isSuccess;

        public static CommitConsumeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CommitConsumeResponseBodyResult self = new CommitConsumeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CommitConsumeResponseBodyResult setIsSuccess(Boolean isSuccess) {
            this.isSuccess = isSuccess;
            return this;
        }
        public Boolean getIsSuccess() {
            return this.isSuccess;
        }

    }

}
