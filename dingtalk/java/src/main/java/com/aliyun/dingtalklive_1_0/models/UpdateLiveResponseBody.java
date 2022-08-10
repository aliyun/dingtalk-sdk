// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateLiveResponseBodyResult result;

    public static UpdateLiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveResponseBody self = new UpdateLiveResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateLiveResponseBody setResult(UpdateLiveResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateLiveResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateLiveResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static UpdateLiveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateLiveResponseBodyResult self = new UpdateLiveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateLiveResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
