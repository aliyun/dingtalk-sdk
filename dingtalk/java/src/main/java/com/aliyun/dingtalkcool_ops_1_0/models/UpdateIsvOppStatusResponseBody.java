// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0.models;

import com.aliyun.tea.*;

public class UpdateIsvOppStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateIsvOppStatusResponseBodyResult result;

    public static UpdateIsvOppStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateIsvOppStatusResponseBody self = new UpdateIsvOppStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateIsvOppStatusResponseBody setResult(UpdateIsvOppStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateIsvOppStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateIsvOppStatusResponseBodyResult extends TeaModel {
        @NameInMap("value")
        public Boolean value;

        public static UpdateIsvOppStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateIsvOppStatusResponseBodyResult self = new UpdateIsvOppStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateIsvOppStatusResponseBodyResult setValue(Boolean value) {
            this.value = value;
            return this;
        }
        public Boolean getValue() {
            return this.value;
        }

    }

}
