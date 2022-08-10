// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DeleteLiveResponseBody extends TeaModel {
    @NameInMap("result")
    public DeleteLiveResponseBodyResult result;

    public static DeleteLiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveResponseBody self = new DeleteLiveResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteLiveResponseBody setResult(DeleteLiveResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DeleteLiveResponseBodyResult getResult() {
        return this.result;
    }

    public static class DeleteLiveResponseBodyResult extends TeaModel {
        @NameInMap("success")
        public Boolean success;

        public static DeleteLiveResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeleteLiveResponseBodyResult self = new DeleteLiveResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeleteLiveResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
