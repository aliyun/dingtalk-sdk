// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateGuardianResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateGuardianResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateGuardianResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateGuardianResponseBody self = new UpdateGuardianResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateGuardianResponseBody setResult(UpdateGuardianResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateGuardianResponseBodyResult getResult() {
        return this.result;
    }

    public UpdateGuardianResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateGuardianResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>234234234</p>
         */
        @NameInMap("bizId")
        public String bizId;

        /**
         * <strong>example:</strong>
         * <p>234234234</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UpdateGuardianResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateGuardianResponseBodyResult self = new UpdateGuardianResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateGuardianResponseBodyResult setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public UpdateGuardianResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
