// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoByPackageIdResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFileDownloadInfoByPackageIdResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetFileDownloadInfoByPackageIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoByPackageIdResponseBody self = new GetFileDownloadInfoByPackageIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoByPackageIdResponseBody setResult(java.util.List<GetFileDownloadInfoByPackageIdResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetFileDownloadInfoByPackageIdResponseBodyResult> getResult() {
        return this.result;
    }

    public GetFileDownloadInfoByPackageIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetFileDownloadInfoByPackageIdResponseBodyResult extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("spaceId")
        public Long spaceId;

        public static GetFileDownloadInfoByPackageIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadInfoByPackageIdResponseBodyResult self = new GetFileDownloadInfoByPackageIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadInfoByPackageIdResponseBodyResult setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetFileDownloadInfoByPackageIdResponseBodyResult setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public GetFileDownloadInfoByPackageIdResponseBodyResult setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
