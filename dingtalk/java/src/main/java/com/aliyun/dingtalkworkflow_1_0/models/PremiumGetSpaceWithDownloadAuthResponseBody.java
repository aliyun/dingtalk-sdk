// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetSpaceWithDownloadAuthResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumGetSpaceWithDownloadAuthResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PremiumGetSpaceWithDownloadAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetSpaceWithDownloadAuthResponseBody self = new PremiumGetSpaceWithDownloadAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGetSpaceWithDownloadAuthResponseBody setResult(PremiumGetSpaceWithDownloadAuthResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGetSpaceWithDownloadAuthResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumGetSpaceWithDownloadAuthResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGetSpaceWithDownloadAuthResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3996960664</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static PremiumGetSpaceWithDownloadAuthResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGetSpaceWithDownloadAuthResponseBodyResult self = new PremiumGetSpaceWithDownloadAuthResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGetSpaceWithDownloadAuthResponseBodyResult setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
