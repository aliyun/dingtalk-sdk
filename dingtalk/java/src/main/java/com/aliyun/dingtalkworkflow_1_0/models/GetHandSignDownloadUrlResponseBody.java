// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetHandSignDownloadUrlResponseBody extends TeaModel {
    @NameInMap("result")
    public GetHandSignDownloadUrlResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static GetHandSignDownloadUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetHandSignDownloadUrlResponseBody self = new GetHandSignDownloadUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetHandSignDownloadUrlResponseBody setResult(GetHandSignDownloadUrlResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetHandSignDownloadUrlResponseBodyResult getResult() {
        return this.result;
    }

    public GetHandSignDownloadUrlResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class GetHandSignDownloadUrlResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="https://dingding-file-zjk.oss-cn-zhangjiakouxxxx">https://dingding-file-zjk.oss-cn-zhangjiakouxxxx</a></p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("expireIn")
        public Long expireIn;

        public static GetHandSignDownloadUrlResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetHandSignDownloadUrlResponseBodyResult self = new GetHandSignDownloadUrlResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetHandSignDownloadUrlResponseBodyResult setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetHandSignDownloadUrlResponseBodyResult setExpireIn(Long expireIn) {
            this.expireIn = expireIn;
            return this;
        }
        public Long getExpireIn() {
            return this.expireIn;
        }

    }

}
