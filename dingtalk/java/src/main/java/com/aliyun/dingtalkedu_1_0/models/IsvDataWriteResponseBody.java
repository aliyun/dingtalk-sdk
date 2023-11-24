// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsvDataWriteResponseBody extends TeaModel {
    @NameInMap("result")
    public IsvDataWriteResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static IsvDataWriteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IsvDataWriteResponseBody self = new IsvDataWriteResponseBody();
        return TeaModel.build(map, self);
    }

    public IsvDataWriteResponseBody setResult(IsvDataWriteResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public IsvDataWriteResponseBodyResult getResult() {
        return this.result;
    }

    public IsvDataWriteResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class IsvDataWriteResponseBodyResult extends TeaModel {
        @NameInMap("needRetry")
        public Boolean needRetry;

        @NameInMap("success")
        public Boolean success;

        public static IsvDataWriteResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            IsvDataWriteResponseBodyResult self = new IsvDataWriteResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public IsvDataWriteResponseBodyResult setNeedRetry(Boolean needRetry) {
            this.needRetry = needRetry;
            return this;
        }
        public Boolean getNeedRetry() {
            return this.needRetry;
        }

        public IsvDataWriteResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
