// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GrantProcessInstanceForDownloadFileResponseBody extends TeaModel {
    @NameInMap("result")
    public GrantProcessInstanceForDownloadFileResponseBodyResult result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GrantProcessInstanceForDownloadFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GrantProcessInstanceForDownloadFileResponseBody self = new GrantProcessInstanceForDownloadFileResponseBody();
        return TeaModel.build(map, self);
    }

    public GrantProcessInstanceForDownloadFileResponseBody setResult(GrantProcessInstanceForDownloadFileResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GrantProcessInstanceForDownloadFileResponseBodyResult getResult() {
        return this.result;
    }

    public GrantProcessInstanceForDownloadFileResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GrantProcessInstanceForDownloadFileResponseBodyResult extends TeaModel {
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

        public static GrantProcessInstanceForDownloadFileResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GrantProcessInstanceForDownloadFileResponseBodyResult self = new GrantProcessInstanceForDownloadFileResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GrantProcessInstanceForDownloadFileResponseBodyResult setDownloadUri(String downloadUri) {
            this.downloadUri = downloadUri;
            return this;
        }
        public String getDownloadUri() {
            return this.downloadUri;
        }

        public GrantProcessInstanceForDownloadFileResponseBodyResult setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GrantProcessInstanceForDownloadFileResponseBodyResult setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
