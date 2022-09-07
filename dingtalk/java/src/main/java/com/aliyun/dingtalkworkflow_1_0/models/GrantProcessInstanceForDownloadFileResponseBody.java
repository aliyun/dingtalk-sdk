// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GrantProcessInstanceForDownloadFileResponseBody extends TeaModel {
    // 请求ID。
    @NameInMap("requestId")
    public String requestId;

    // 返回结果。
    @NameInMap("result")
    public GrantProcessInstanceForDownloadFileResponseBodyResult result;

    // 接口调用是否成功。
    @NameInMap("success")
    public Boolean success;

    public static GrantProcessInstanceForDownloadFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GrantProcessInstanceForDownloadFileResponseBody self = new GrantProcessInstanceForDownloadFileResponseBody();
        return TeaModel.build(map, self);
    }

    public GrantProcessInstanceForDownloadFileResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
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
        // 文件下载地址。
        @NameInMap("downloadUri")
        public String downloadUri;

        // 文件ID。
        @NameInMap("fileId")
        public String fileId;

        // 钉盘空间ID。
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
