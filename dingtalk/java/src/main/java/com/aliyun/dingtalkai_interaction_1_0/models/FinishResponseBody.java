// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class FinishResponseBody extends TeaModel {
    @NameInMap("result")
    public FinishResponseBodyResult result;

    public static FinishResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FinishResponseBody self = new FinishResponseBody();
        return TeaModel.build(map, self);
    }

    public FinishResponseBody setResult(FinishResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public FinishResponseBodyResult getResult() {
        return this.result;
    }

    public static class FinishResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static FinishResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            FinishResponseBodyResult self = new FinishResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public FinishResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
