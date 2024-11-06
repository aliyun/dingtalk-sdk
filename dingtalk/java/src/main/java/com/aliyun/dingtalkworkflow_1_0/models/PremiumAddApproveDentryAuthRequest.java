// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumAddApproveDentryAuthRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fileInfos")
    public java.util.List<PremiumAddApproveDentryAuthRequestFileInfos> fileInfos;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PremiumAddApproveDentryAuthRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumAddApproveDentryAuthRequest self = new PremiumAddApproveDentryAuthRequest();
        return TeaModel.build(map, self);
    }

    public PremiumAddApproveDentryAuthRequest setFileInfos(java.util.List<PremiumAddApproveDentryAuthRequestFileInfos> fileInfos) {
        this.fileInfos = fileInfos;
        return this;
    }
    public java.util.List<PremiumAddApproveDentryAuthRequestFileInfos> getFileInfos() {
        return this.fileInfos;
    }

    public PremiumAddApproveDentryAuthRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class PremiumAddApproveDentryAuthRequestFileInfos extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>B1oQixxxx</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>111</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static PremiumAddApproveDentryAuthRequestFileInfos build(java.util.Map<String, ?> map) throws Exception {
            PremiumAddApproveDentryAuthRequestFileInfos self = new PremiumAddApproveDentryAuthRequestFileInfos();
            return TeaModel.build(map, self);
        }

        public PremiumAddApproveDentryAuthRequestFileInfos setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public PremiumAddApproveDentryAuthRequestFileInfos setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
