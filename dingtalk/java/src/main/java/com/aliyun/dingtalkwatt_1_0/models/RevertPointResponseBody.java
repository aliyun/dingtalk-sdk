// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class RevertPointResponseBody extends TeaModel {
    @NameInMap("result")
    public RevertPointResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static RevertPointResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RevertPointResponseBody self = new RevertPointResponseBody();
        return TeaModel.build(map, self);
    }

    public RevertPointResponseBody setResult(RevertPointResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public RevertPointResponseBodyResult getResult() {
        return this.result;
    }

    public RevertPointResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RevertPointResponseBodyResult extends TeaModel {
        @NameInMap("revertedPoints")
        public Long revertedPoints;

        public static RevertPointResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RevertPointResponseBodyResult self = new RevertPointResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RevertPointResponseBodyResult setRevertedPoints(Long revertedPoints) {
            this.revertedPoints = revertedPoints;
            return this;
        }
        public Long getRevertedPoints() {
            return this.revertedPoints;
        }

    }

}
