// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class GrantHonorResponseBody extends TeaModel {
    @NameInMap("result")
    public GrantHonorResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GrantHonorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GrantHonorResponseBody self = new GrantHonorResponseBody();
        return TeaModel.build(map, self);
    }

    public GrantHonorResponseBody setResult(GrantHonorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GrantHonorResponseBodyResult getResult() {
        return this.result;
    }

    public GrantHonorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GrantHonorResponseBodyResult extends TeaModel {
        /**
         * <p>失败的userId</p>
         */
        @NameInMap("failedUserIds")
        public java.util.List<String> failedUserIds;

        /**
         * <p>成功的userId</p>
         */
        @NameInMap("successUserIds")
        public java.util.List<String> successUserIds;

        public static GrantHonorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GrantHonorResponseBodyResult self = new GrantHonorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GrantHonorResponseBodyResult setFailedUserIds(java.util.List<String> failedUserIds) {
            this.failedUserIds = failedUserIds;
            return this;
        }
        public java.util.List<String> getFailedUserIds() {
            return this.failedUserIds;
        }

        public GrantHonorResponseBodyResult setSuccessUserIds(java.util.List<String> successUserIds) {
            this.successUserIds = successUserIds;
            return this;
        }
        public java.util.List<String> getSuccessUserIds() {
            return this.successUserIds;
        }

    }

}
