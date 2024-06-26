// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class GetPictureDownloadUrlResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public GetPictureDownloadUrlResponseBodyResult result;

    public static GetPictureDownloadUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPictureDownloadUrlResponseBody self = new GetPictureDownloadUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPictureDownloadUrlResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetPictureDownloadUrlResponseBody setResult(GetPictureDownloadUrlResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetPictureDownloadUrlResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetPictureDownloadUrlResponseBodyResult extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>FOLLOWED</p>
         */
        @NameInMap("url")
        public String url;

        public static GetPictureDownloadUrlResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetPictureDownloadUrlResponseBodyResult self = new GetPictureDownloadUrlResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetPictureDownloadUrlResponseBodyResult setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
