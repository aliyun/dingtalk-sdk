// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ProvidePointResponseBody extends TeaModel {
    @NameInMap("result")
    public ProvidePointResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ProvidePointResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProvidePointResponseBody self = new ProvidePointResponseBody();
        return TeaModel.build(map, self);
    }

    public ProvidePointResponseBody setResult(ProvidePointResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ProvidePointResponseBodyResult getResult() {
        return this.result;
    }

    public ProvidePointResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ProvidePointResponseBodyResult extends TeaModel {
        @NameInMap("availableQuota")
        public Long availableQuota;

        @NameInMap("provideNum")
        public Long provideNum;

        @NameInMap("provideSuccess")
        public Boolean provideSuccess;

        public static ProvidePointResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ProvidePointResponseBodyResult self = new ProvidePointResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ProvidePointResponseBodyResult setAvailableQuota(Long availableQuota) {
            this.availableQuota = availableQuota;
            return this;
        }
        public Long getAvailableQuota() {
            return this.availableQuota;
        }

        public ProvidePointResponseBodyResult setProvideNum(Long provideNum) {
            this.provideNum = provideNum;
            return this;
        }
        public Long getProvideNum() {
            return this.provideNum;
        }

        public ProvidePointResponseBodyResult setProvideSuccess(Boolean provideSuccess) {
            this.provideSuccess = provideSuccess;
            return this;
        }
        public Boolean getProvideSuccess() {
            return this.provideSuccess;
        }

    }

}
