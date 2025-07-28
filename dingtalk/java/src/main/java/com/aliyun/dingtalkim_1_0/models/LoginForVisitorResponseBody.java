// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class LoginForVisitorResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("aimInfo")
    public LoginForVisitorResponseBodyAimInfo aimInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("aimToken")
    public LoginForVisitorResponseBodyAimToken aimToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("appUid")
    public String appUid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>channel_123</p>
     */
    @NameInMap("channelCode")
    public String channelCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>device_001</p>
     */
    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <strong>example:</strong>
     * <p>example.com</p>
     */
    @NameInMap("safeDomainName")
    public String safeDomainName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("userName")
    public String userName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>@123456</p>
     */
    @NameInMap("visitorAvatar")
    public String visitorAvatar;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://example.com/acd123.jpg">https://example.com/acd123.jpg</a></p>
     */
    @NameInMap("visitorAvatarUrl")
    public String visitorAvatarUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cid_12345</p>
     */
    @NameInMap("visitorCid")
    public String visitorCid;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>openconversation_12345</p>
     */
    @NameInMap("visitorOpenConversationId")
    public String visitorOpenConversationId;

    public static LoginForVisitorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LoginForVisitorResponseBody self = new LoginForVisitorResponseBody();
        return TeaModel.build(map, self);
    }

    public LoginForVisitorResponseBody setAimInfo(LoginForVisitorResponseBodyAimInfo aimInfo) {
        this.aimInfo = aimInfo;
        return this;
    }
    public LoginForVisitorResponseBodyAimInfo getAimInfo() {
        return this.aimInfo;
    }

    public LoginForVisitorResponseBody setAimToken(LoginForVisitorResponseBodyAimToken aimToken) {
        this.aimToken = aimToken;
        return this;
    }
    public LoginForVisitorResponseBodyAimToken getAimToken() {
        return this.aimToken;
    }

    public LoginForVisitorResponseBody setAppUid(String appUid) {
        this.appUid = appUid;
        return this;
    }
    public String getAppUid() {
        return this.appUid;
    }

    public LoginForVisitorResponseBody setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public LoginForVisitorResponseBody setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public LoginForVisitorResponseBody setSafeDomainName(String safeDomainName) {
        this.safeDomainName = safeDomainName;
        return this;
    }
    public String getSafeDomainName() {
        return this.safeDomainName;
    }

    public LoginForVisitorResponseBody setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public LoginForVisitorResponseBody setVisitorAvatar(String visitorAvatar) {
        this.visitorAvatar = visitorAvatar;
        return this;
    }
    public String getVisitorAvatar() {
        return this.visitorAvatar;
    }

    public LoginForVisitorResponseBody setVisitorAvatarUrl(String visitorAvatarUrl) {
        this.visitorAvatarUrl = visitorAvatarUrl;
        return this;
    }
    public String getVisitorAvatarUrl() {
        return this.visitorAvatarUrl;
    }

    public LoginForVisitorResponseBody setVisitorCid(String visitorCid) {
        this.visitorCid = visitorCid;
        return this;
    }
    public String getVisitorCid() {
        return this.visitorCid;
    }

    public LoginForVisitorResponseBody setVisitorOpenConversationId(String visitorOpenConversationId) {
        this.visitorOpenConversationId = visitorOpenConversationId;
        return this;
    }
    public String getVisitorOpenConversationId() {
        return this.visitorOpenConversationId;
    }

    public static class LoginForVisitorResponseBodyAimInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>app_123456</p>
         */
        @NameInMap("appId")
        public String appId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("appKey")
        public java.util.Map<String, String> appKey;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dingtalk_app</p>
         */
        @NameInMap("appName")
        public String appName;

        public static LoginForVisitorResponseBodyAimInfo build(java.util.Map<String, ?> map) throws Exception {
            LoginForVisitorResponseBodyAimInfo self = new LoginForVisitorResponseBodyAimInfo();
            return TeaModel.build(map, self);
        }

        public LoginForVisitorResponseBodyAimInfo setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public LoginForVisitorResponseBodyAimInfo setAppKey(java.util.Map<String, String> appKey) {
            this.appKey = appKey;
            return this;
        }
        public java.util.Map<String, String> getAppKey() {
            return this.appKey;
        }

        public LoginForVisitorResponseBodyAimInfo setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

    }

    public static class LoginForVisitorResponseBodyAimToken extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abc123xyz</p>
         */
        @NameInMap("accessToken")
        public String accessToken;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>86400</p>
         */
        @NameInMap("accessTokenExpiredTime")
        public Long accessTokenExpiredTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1717027200000</p>
         */
        @NameInMap("buildTime")
        public Long buildTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>refreshtoken_789</p>
         */
        @NameInMap("refreshToken")
        public String refreshToken;

        public static LoginForVisitorResponseBodyAimToken build(java.util.Map<String, ?> map) throws Exception {
            LoginForVisitorResponseBodyAimToken self = new LoginForVisitorResponseBodyAimToken();
            return TeaModel.build(map, self);
        }

        public LoginForVisitorResponseBodyAimToken setAccessToken(String accessToken) {
            this.accessToken = accessToken;
            return this;
        }
        public String getAccessToken() {
            return this.accessToken;
        }

        public LoginForVisitorResponseBodyAimToken setAccessTokenExpiredTime(Long accessTokenExpiredTime) {
            this.accessTokenExpiredTime = accessTokenExpiredTime;
            return this;
        }
        public Long getAccessTokenExpiredTime() {
            return this.accessTokenExpiredTime;
        }

        public LoginForVisitorResponseBodyAimToken setBuildTime(Long buildTime) {
            this.buildTime = buildTime;
            return this;
        }
        public Long getBuildTime() {
            return this.buildTime;
        }

        public LoginForVisitorResponseBodyAimToken setRefreshToken(String refreshToken) {
            this.refreshToken = refreshToken;
            return this;
        }
        public String getRefreshToken() {
            return this.refreshToken;
        }

    }

}
