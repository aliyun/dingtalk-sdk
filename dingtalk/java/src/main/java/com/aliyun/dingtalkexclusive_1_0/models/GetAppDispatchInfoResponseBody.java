// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAppDispatchInfoResponseBody extends TeaModel {
    /**
     * <p>android打包记录</p>
     */
    @NameInMap("android")
    public java.util.List<GetAppDispatchInfoResponseBodyAndroid> android;

    /**
     * <p>iOS打包记录</p>
     */
    @NameInMap("iOS")
    public java.util.List<GetAppDispatchInfoResponseBodyIOS> iOS;

    /**
     * <p>mac打包记录</p>
     */
    @NameInMap("mac")
    public java.util.List<GetAppDispatchInfoResponseBodyMac> mac;

    /**
     * <p>windows打包记录</p>
     */
    @NameInMap("windows")
    public java.util.List<GetAppDispatchInfoResponseBodyWindows> windows;

    public static GetAppDispatchInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAppDispatchInfoResponseBody self = new GetAppDispatchInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAppDispatchInfoResponseBody setAndroid(java.util.List<GetAppDispatchInfoResponseBodyAndroid> android) {
        this.android = android;
        return this;
    }
    public java.util.List<GetAppDispatchInfoResponseBodyAndroid> getAndroid() {
        return this.android;
    }

    public GetAppDispatchInfoResponseBody setIOS(java.util.List<GetAppDispatchInfoResponseBodyIOS> iOS) {
        this.iOS = iOS;
        return this;
    }
    public java.util.List<GetAppDispatchInfoResponseBodyIOS> getIOS() {
        return this.iOS;
    }

    public GetAppDispatchInfoResponseBody setMac(java.util.List<GetAppDispatchInfoResponseBodyMac> mac) {
        this.mac = mac;
        return this;
    }
    public java.util.List<GetAppDispatchInfoResponseBodyMac> getMac() {
        return this.mac;
    }

    public GetAppDispatchInfoResponseBody setWindows(java.util.List<GetAppDispatchInfoResponseBodyWindows> windows) {
        this.windows = windows;
        return this;
    }
    public java.util.List<GetAppDispatchInfoResponseBodyWindows> getWindows() {
        return this.windows;
    }

    public static class GetAppDispatchInfoResponseBodyAndroid extends TeaModel {
        /**
         * <p>基线版本</p>
         */
        @NameInMap("baseLineVersion")
        public String baseLineVersion;

        /**
         * <p>下载地址</p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        /**
         * <p>是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布</p>
         */
        @NameInMap("inGray")
        public Boolean inGray;

        /**
         * <p>打包时间</p>
         */
        @NameInMap("packTime")
        public Long packTime;

        /**
         * <p>客户端类型</p>
         */
        @NameInMap("platform")
        public String platform;

        /**
         * <p>版本号</p>
         */
        @NameInMap("version")
        public String version;

        public static GetAppDispatchInfoResponseBodyAndroid build(java.util.Map<String, ?> map) throws Exception {
            GetAppDispatchInfoResponseBodyAndroid self = new GetAppDispatchInfoResponseBodyAndroid();
            return TeaModel.build(map, self);
        }

        public GetAppDispatchInfoResponseBodyAndroid setBaseLineVersion(String baseLineVersion) {
            this.baseLineVersion = baseLineVersion;
            return this;
        }
        public String getBaseLineVersion() {
            return this.baseLineVersion;
        }

        public GetAppDispatchInfoResponseBodyAndroid setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetAppDispatchInfoResponseBodyAndroid setInGray(Boolean inGray) {
            this.inGray = inGray;
            return this;
        }
        public Boolean getInGray() {
            return this.inGray;
        }

        public GetAppDispatchInfoResponseBodyAndroid setPackTime(Long packTime) {
            this.packTime = packTime;
            return this;
        }
        public Long getPackTime() {
            return this.packTime;
        }

        public GetAppDispatchInfoResponseBodyAndroid setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public GetAppDispatchInfoResponseBodyAndroid setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class GetAppDispatchInfoResponseBodyIOSExt extends TeaModel {
        /**
         * <p>plist下载地址</p>
         */
        @NameInMap("plist")
        public String plist;

        public static GetAppDispatchInfoResponseBodyIOSExt build(java.util.Map<String, ?> map) throws Exception {
            GetAppDispatchInfoResponseBodyIOSExt self = new GetAppDispatchInfoResponseBodyIOSExt();
            return TeaModel.build(map, self);
        }

        public GetAppDispatchInfoResponseBodyIOSExt setPlist(String plist) {
            this.plist = plist;
            return this;
        }
        public String getPlist() {
            return this.plist;
        }

    }

    public static class GetAppDispatchInfoResponseBodyIOS extends TeaModel {
        /**
         * <p>基线版本</p>
         */
        @NameInMap("baseLineVersion")
        public String baseLineVersion;

        /**
         * <p>下载地址</p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("ext")
        public GetAppDispatchInfoResponseBodyIOSExt ext;

        /**
         * <p>是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布</p>
         */
        @NameInMap("inGray")
        public Boolean inGray;

        /**
         * <p>打包时间</p>
         */
        @NameInMap("packTime")
        public Long packTime;

        /**
         * <p>客户端类型</p>
         */
        @NameInMap("platform")
        public String platform;

        /**
         * <p>版本号</p>
         */
        @NameInMap("version")
        public String version;

        public static GetAppDispatchInfoResponseBodyIOS build(java.util.Map<String, ?> map) throws Exception {
            GetAppDispatchInfoResponseBodyIOS self = new GetAppDispatchInfoResponseBodyIOS();
            return TeaModel.build(map, self);
        }

        public GetAppDispatchInfoResponseBodyIOS setBaseLineVersion(String baseLineVersion) {
            this.baseLineVersion = baseLineVersion;
            return this;
        }
        public String getBaseLineVersion() {
            return this.baseLineVersion;
        }

        public GetAppDispatchInfoResponseBodyIOS setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetAppDispatchInfoResponseBodyIOS setExt(GetAppDispatchInfoResponseBodyIOSExt ext) {
            this.ext = ext;
            return this;
        }
        public GetAppDispatchInfoResponseBodyIOSExt getExt() {
            return this.ext;
        }

        public GetAppDispatchInfoResponseBodyIOS setInGray(Boolean inGray) {
            this.inGray = inGray;
            return this;
        }
        public Boolean getInGray() {
            return this.inGray;
        }

        public GetAppDispatchInfoResponseBodyIOS setPackTime(Long packTime) {
            this.packTime = packTime;
            return this;
        }
        public Long getPackTime() {
            return this.packTime;
        }

        public GetAppDispatchInfoResponseBodyIOS setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public GetAppDispatchInfoResponseBodyIOS setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class GetAppDispatchInfoResponseBodyMac extends TeaModel {
        /**
         * <p>基线版本</p>
         */
        @NameInMap("baseLineVersion")
        public String baseLineVersion;

        /**
         * <p>下载地址</p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        /**
         * <p>是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布</p>
         */
        @NameInMap("inGray")
        public Boolean inGray;

        /**
         * <p>打包时间</p>
         */
        @NameInMap("packTime")
        public Long packTime;

        /**
         * <p>客户端类型</p>
         */
        @NameInMap("platform")
        public String platform;

        /**
         * <p>版本号</p>
         */
        @NameInMap("version")
        public String version;

        public static GetAppDispatchInfoResponseBodyMac build(java.util.Map<String, ?> map) throws Exception {
            GetAppDispatchInfoResponseBodyMac self = new GetAppDispatchInfoResponseBodyMac();
            return TeaModel.build(map, self);
        }

        public GetAppDispatchInfoResponseBodyMac setBaseLineVersion(String baseLineVersion) {
            this.baseLineVersion = baseLineVersion;
            return this;
        }
        public String getBaseLineVersion() {
            return this.baseLineVersion;
        }

        public GetAppDispatchInfoResponseBodyMac setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetAppDispatchInfoResponseBodyMac setInGray(Boolean inGray) {
            this.inGray = inGray;
            return this;
        }
        public Boolean getInGray() {
            return this.inGray;
        }

        public GetAppDispatchInfoResponseBodyMac setPackTime(Long packTime) {
            this.packTime = packTime;
            return this;
        }
        public Long getPackTime() {
            return this.packTime;
        }

        public GetAppDispatchInfoResponseBodyMac setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public GetAppDispatchInfoResponseBodyMac setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

    public static class GetAppDispatchInfoResponseBodyWindows extends TeaModel {
        /**
         * <p>基线版本</p>
         */
        @NameInMap("baseLineVersion")
        public String baseLineVersion;

        /**
         * <p>下载地址</p>
         */
        @NameInMap("downloadUrl")
        public String downloadUrl;

        /**
         * <p>是否灰度。true 灰度发布中 | false 全量灰度发布。为空则为未发布</p>
         */
        @NameInMap("inGray")
        public Boolean inGray;

        /**
         * <p>打包时间</p>
         */
        @NameInMap("packTime")
        public Long packTime;

        /**
         * <p>客户端类型</p>
         */
        @NameInMap("platform")
        public String platform;

        /**
         * <p>版本号</p>
         */
        @NameInMap("version")
        public String version;

        public static GetAppDispatchInfoResponseBodyWindows build(java.util.Map<String, ?> map) throws Exception {
            GetAppDispatchInfoResponseBodyWindows self = new GetAppDispatchInfoResponseBodyWindows();
            return TeaModel.build(map, self);
        }

        public GetAppDispatchInfoResponseBodyWindows setBaseLineVersion(String baseLineVersion) {
            this.baseLineVersion = baseLineVersion;
            return this;
        }
        public String getBaseLineVersion() {
            return this.baseLineVersion;
        }

        public GetAppDispatchInfoResponseBodyWindows setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetAppDispatchInfoResponseBodyWindows setInGray(Boolean inGray) {
            this.inGray = inGray;
            return this;
        }
        public Boolean getInGray() {
            return this.inGray;
        }

        public GetAppDispatchInfoResponseBodyWindows setPackTime(Long packTime) {
            this.packTime = packTime;
            return this;
        }
        public Long getPackTime() {
            return this.packTime;
        }

        public GetAppDispatchInfoResponseBodyWindows setPlatform(String platform) {
            this.platform = platform;
            return this;
        }
        public String getPlatform() {
            return this.platform;
        }

        public GetAppDispatchInfoResponseBodyWindows setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

    }

}
