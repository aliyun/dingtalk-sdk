// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ShareUrlResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>shareUrlInfo</p>
     */
    @NameInMap("shareUrlInfo")
    public ShareUrlResponseBodyShareUrlInfo shareUrlInfo;

    public static ShareUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ShareUrlResponseBody self = new ShareUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public ShareUrlResponseBody setShareUrlInfo(ShareUrlResponseBodyShareUrlInfo shareUrlInfo) {
        this.shareUrlInfo = shareUrlInfo;
        return this;
    }
    public ShareUrlResponseBodyShareUrlInfo getShareUrlInfo() {
        return this.shareUrlInfo;
    }

    public static class ShareUrlResponseBodyShareUrlInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p><a href="http://example.com">http://example.com</a></p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <strong>example:</strong>
         * <p><a href="http://example.com">http://example.com</a></p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        public static ShareUrlResponseBodyShareUrlInfo build(java.util.Map<String, ?> map) throws Exception {
            ShareUrlResponseBodyShareUrlInfo self = new ShareUrlResponseBodyShareUrlInfo();
            return TeaModel.build(map, self);
        }

        public ShareUrlResponseBodyShareUrlInfo setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public ShareUrlResponseBodyShareUrlInfo setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

}
