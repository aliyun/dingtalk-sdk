// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class RecallHonorResponseBody extends TeaModel {
    @NameInMap("result")
    public RecallHonorResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static RecallHonorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RecallHonorResponseBody self = new RecallHonorResponseBody();
        return TeaModel.build(map, self);
    }

    public RecallHonorResponseBody setResult(RecallHonorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public RecallHonorResponseBodyResult getResult() {
        return this.result;
    }

    public RecallHonorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RecallHonorResponseBodyResult extends TeaModel {
        @NameInMap("honorId")
        public String honorId;

        public static RecallHonorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            RecallHonorResponseBodyResult self = new RecallHonorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public RecallHonorResponseBodyResult setHonorId(String honorId) {
            this.honorId = honorId;
            return this;
        }
        public String getHonorId() {
            return this.honorId;
        }

    }

}
