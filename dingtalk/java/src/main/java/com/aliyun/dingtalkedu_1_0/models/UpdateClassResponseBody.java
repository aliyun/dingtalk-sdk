// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateClassResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateClassResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateClassResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateClassResponseBody self = new UpdateClassResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateClassResponseBody setResult(UpdateClassResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateClassResponseBodyResult getResult() {
        return this.result;
    }

    public UpdateClassResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateClassResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>234324</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        public static UpdateClassResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateClassResponseBodyResult self = new UpdateClassResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateClassResponseBodyResult setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

    }

}
