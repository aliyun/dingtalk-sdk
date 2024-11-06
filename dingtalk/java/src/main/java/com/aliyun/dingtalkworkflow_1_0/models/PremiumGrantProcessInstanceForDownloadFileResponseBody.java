// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGrantProcessInstanceForDownloadFileResponseBody extends TeaModel {
    @NameInMap("result")
    public PremiumGrantProcessInstanceForDownloadFileResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PremiumGrantProcessInstanceForDownloadFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumGrantProcessInstanceForDownloadFileResponseBody self = new PremiumGrantProcessInstanceForDownloadFileResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumGrantProcessInstanceForDownloadFileResponseBody setResult(PremiumGrantProcessInstanceForDownloadFileResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public PremiumGrantProcessInstanceForDownloadFileResponseBodyResult getResult() {
        return this.result;
    }

    public PremiumGrantProcessInstanceForDownloadFileResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class PremiumGrantProcessInstanceForDownloadFileResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="http://lippi-space-zjk.oss-cn-zhangjiakou.aliyuncs.com/xxxxx">http://lippi-space-zjk.oss-cn-zhangjiakou.aliyuncs.com/xxxxx</a></p>
         */
        @NameInMap("downloadUri")
        public String downloadUri;

        /**
         * <strong>example:</strong>
         * <p>26748422566</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <strong>example:</strong>
         * <p>3996960664</p>
         */
        @NameInMap("spaceId")
        public Long spaceId;

        public static PremiumGrantProcessInstanceForDownloadFileResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PremiumGrantProcessInstanceForDownloadFileResponseBodyResult self = new PremiumGrantProcessInstanceForDownloadFileResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PremiumGrantProcessInstanceForDownloadFileResponseBodyResult setDownloadUri(String downloadUri) {
            this.downloadUri = downloadUri;
            return this;
        }
        public String getDownloadUri() {
            return this.downloadUri;
        }

        public PremiumGrantProcessInstanceForDownloadFileResponseBodyResult setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public PremiumGrantProcessInstanceForDownloadFileResponseBodyResult setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
