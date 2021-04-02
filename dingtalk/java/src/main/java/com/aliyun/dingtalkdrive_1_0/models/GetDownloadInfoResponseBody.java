// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoResponseBody extends TeaModel {
    // 下载加签url信息
    @NameInMap("presignedUrlDownloadInfo")
    public GetDownloadInfoResponseBodyPresignedUrlDownloadInfo presignedUrlDownloadInfo;

    public static GetDownloadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadInfoResponseBody self = new GetDownloadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDownloadInfoResponseBody setPresignedUrlDownloadInfo(GetDownloadInfoResponseBodyPresignedUrlDownloadInfo presignedUrlDownloadInfo) {
        this.presignedUrlDownloadInfo = presignedUrlDownloadInfo;
        return this;
    }
    public GetDownloadInfoResponseBodyPresignedUrlDownloadInfo getPresignedUrlDownloadInfo() {
        return this.presignedUrlDownloadInfo;
    }

    public static class GetDownloadInfoResponseBodyPresignedUrlDownloadInfo extends TeaModel {
        // 加签url
        @NameInMap("resourceUrl")
        public String resourceUrl;

        // 加签url过期时间(分钟)
        @NameInMap("expiration")
        public Integer expiration;

        public static GetDownloadInfoResponseBodyPresignedUrlDownloadInfo build(java.util.Map<String, ?> map) throws Exception {
            GetDownloadInfoResponseBodyPresignedUrlDownloadInfo self = new GetDownloadInfoResponseBodyPresignedUrlDownloadInfo();
            return TeaModel.build(map, self);
        }

        public GetDownloadInfoResponseBodyPresignedUrlDownloadInfo setResourceUrl(String resourceUrl) {
            this.resourceUrl = resourceUrl;
            return this;
        }
        public String getResourceUrl() {
            return this.resourceUrl;
        }

        public GetDownloadInfoResponseBodyPresignedUrlDownloadInfo setExpiration(Integer expiration) {
            this.expiration = expiration;
            return this;
        }
        public Integer getExpiration() {
            return this.expiration;
        }

    }

}
