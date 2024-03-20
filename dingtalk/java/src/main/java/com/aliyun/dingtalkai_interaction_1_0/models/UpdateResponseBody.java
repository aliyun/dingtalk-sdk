// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class UpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateResponseBodyResult result;

    public static UpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResponseBody self = new UpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResponseBody setResult(UpdateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static UpdateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateResponseBodyResult self = new UpdateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
