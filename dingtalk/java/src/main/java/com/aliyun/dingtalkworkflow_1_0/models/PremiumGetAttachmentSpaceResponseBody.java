// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetAttachmentSpaceResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumGetAttachmentSpaceResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PremiumGetAttachmentSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetAttachmentSpaceResponseBody self = new PremiumGetAttachmentSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetAttachmentSpaceResponseBody setResult(PremiumGetAttachmentSpaceResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetAttachmentSpaceResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumGetAttachmentSpaceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGetAttachmentSpaceResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3996960664</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static PremiumGetAttachmentSpaceResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetAttachmentSpaceResponseBodyResult self = new PremiumGetAttachmentSpaceResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetAttachmentSpaceResponseBodyResult setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
