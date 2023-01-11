// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetAuthInfoResponseBody extends TeaModel {
    /**
     * <p>授权应用信息</p>
     */
    @NameInMap("authAppInfo")
    public GetAuthInfoResponseBodyAuthAppInfo authAppInfo;

    /**
     * <p>应用企业信息</p>
     */
    @NameInMap("authCorpInfo")
    public GetAuthInfoResponseBodyAuthCorpInfo authCorpInfo;

    /**
     * <p>授权用户信息</p>
     */
    @NameInMap("authUserInfo")
    public GetAuthInfoResponseBodyAuthUserInfo authUserInfo;

    public static GetAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAuthInfoResponseBody self = new GetAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAuthInfoResponseBody setAuthAppInfo(GetAuthInfoResponseBodyAuthAppInfo authAppInfo) {
        this.authAppInfo = authAppInfo;
        return this;
    }
    public GetAuthInfoResponseBodyAuthAppInfo getAuthAppInfo() {
        return this.authAppInfo;
    }

    public GetAuthInfoResponseBody setAuthCorpInfo(GetAuthInfoResponseBodyAuthCorpInfo authCorpInfo) {
        this.authCorpInfo = authCorpInfo;
        return this;
    }
    public GetAuthInfoResponseBodyAuthCorpInfo getAuthCorpInfo() {
        return this.authCorpInfo;
    }

    public GetAuthInfoResponseBody setAuthUserInfo(GetAuthInfoResponseBodyAuthUserInfo authUserInfo) {
        this.authUserInfo = authUserInfo;
        return this;
    }
    public GetAuthInfoResponseBodyAuthUserInfo getAuthUserInfo() {
        return this.authUserInfo;
    }

    public static class GetAuthInfoResponseBodyAuthAppInfoAgentList extends TeaModel {
        /**
         * <p>对此微应用有管理权限的管理员列表</p>
         */
        @NameInMap("adminList")
        public java.util.List<String> adminList;

        /**
         * <p>应用id</p>
         */
        @NameInMap("agentId")
        public Long agentId;

        /**
         * <p>应用名称</p>
         */
        @NameInMap("agentName")
        public String agentName;

        /**
         * <p>三方应用id</p>
         */
        @NameInMap("appId")
        public Long appId;

        public static GetAuthInfoResponseBodyAuthAppInfoAgentList build(java.util.Map<String, ?> map) throws Exception {
            GetAuthInfoResponseBodyAuthAppInfoAgentList self = new GetAuthInfoResponseBodyAuthAppInfoAgentList();
            return TeaModel.build(map, self);
        }

        public GetAuthInfoResponseBodyAuthAppInfoAgentList setAdminList(java.util.List<String> adminList) {
            this.adminList = adminList;
            return this;
        }
        public java.util.List<String> getAdminList() {
            return this.adminList;
        }

        public GetAuthInfoResponseBodyAuthAppInfoAgentList setAgentId(Long agentId) {
            this.agentId = agentId;
            return this;
        }
        public Long getAgentId() {
            return this.agentId;
        }

        public GetAuthInfoResponseBodyAuthAppInfoAgentList setAgentName(String agentName) {
            this.agentName = agentName;
            return this;
        }
        public String getAgentName() {
            return this.agentName;
        }

        public GetAuthInfoResponseBodyAuthAppInfoAgentList setAppId(Long appId) {
            this.appId = appId;
            return this;
        }
        public Long getAppId() {
            return this.appId;
        }

    }

    public static class GetAuthInfoResponseBodyAuthAppInfo extends TeaModel {
        @NameInMap("agentList")
        public java.util.List<GetAuthInfoResponseBodyAuthAppInfoAgentList> agentList;

        public static GetAuthInfoResponseBodyAuthAppInfo build(java.util.Map<String, ?> map) throws Exception {
            GetAuthInfoResponseBodyAuthAppInfo self = new GetAuthInfoResponseBodyAuthAppInfo();
            return TeaModel.build(map, self);
        }

        public GetAuthInfoResponseBodyAuthAppInfo setAgentList(java.util.List<GetAuthInfoResponseBodyAuthAppInfoAgentList> agentList) {
            this.agentList = agentList;
            return this;
        }
        public java.util.List<GetAuthInfoResponseBodyAuthAppInfoAgentList> getAgentList() {
            return this.agentList;
        }

    }

    public static class GetAuthInfoResponseBodyAuthCorpInfo extends TeaModel {
        /**
         * <p>渠道码。</p>
         */
        @NameInMap("authChannel")
        public String authChannel;

        /**
         * <p>渠道类型。  为了避免渠道码重复，可与渠道码共同确认渠道。可能为空，非空时当前只有满天星类型，值为STAR_ACTIVITY。</p>
         */
        @NameInMap("authChannelType")
        public String authChannelType;

        /**
         * <p>企业认证等级：  0：未认证  1：高级认证  2：中级认证  3：初级认证</p>
         */
        @NameInMap("authLevel")
        public Long authLevel;

        /**
         * <p>企业logo。</p>
         */
        @NameInMap("corpLogoUrl")
        public String corpLogoUrl;

        /**
         * <p>授权方企业名称。</p>
         */
        @NameInMap("corpName")
        public String corpName;

        /**
         * <p>企业所属行业。</p>
         */
        @NameInMap("industry")
        public String industry;

        /**
         * <p>邀请码，只有自己邀请的企业才会返回邀请码，可用该邀请码统计不同渠道的拉新，否则值为空字符串。</p>
         */
        @NameInMap("inviteCode")
        public String inviteCode;

        /**
         * <p>企业邀请链接。</p>
         */
        @NameInMap("inviteUrl")
        public String inviteUrl;

        /**
         * <p>序列号。</p>
         */
        @NameInMap("licenseCode")
        public String licenseCode;

        public static GetAuthInfoResponseBodyAuthCorpInfo build(java.util.Map<String, ?> map) throws Exception {
            GetAuthInfoResponseBodyAuthCorpInfo self = new GetAuthInfoResponseBodyAuthCorpInfo();
            return TeaModel.build(map, self);
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setAuthChannel(String authChannel) {
            this.authChannel = authChannel;
            return this;
        }
        public String getAuthChannel() {
            return this.authChannel;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setAuthChannelType(String authChannelType) {
            this.authChannelType = authChannelType;
            return this;
        }
        public String getAuthChannelType() {
            return this.authChannelType;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setAuthLevel(Long authLevel) {
            this.authLevel = authLevel;
            return this;
        }
        public Long getAuthLevel() {
            return this.authLevel;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setCorpLogoUrl(String corpLogoUrl) {
            this.corpLogoUrl = corpLogoUrl;
            return this;
        }
        public String getCorpLogoUrl() {
            return this.corpLogoUrl;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setCorpName(String corpName) {
            this.corpName = corpName;
            return this;
        }
        public String getCorpName() {
            return this.corpName;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setIndustry(String industry) {
            this.industry = industry;
            return this;
        }
        public String getIndustry() {
            return this.industry;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setInviteCode(String inviteCode) {
            this.inviteCode = inviteCode;
            return this;
        }
        public String getInviteCode() {
            return this.inviteCode;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setInviteUrl(String inviteUrl) {
            this.inviteUrl = inviteUrl;
            return this;
        }
        public String getInviteUrl() {
            return this.inviteUrl;
        }

        public GetAuthInfoResponseBodyAuthCorpInfo setLicenseCode(String licenseCode) {
            this.licenseCode = licenseCode;
            return this;
        }
        public String getLicenseCode() {
            return this.licenseCode;
        }

    }

    public static class GetAuthInfoResponseBodyAuthUserInfo extends TeaModel {
        /**
         * <p>授权管理员id</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetAuthInfoResponseBodyAuthUserInfo build(java.util.Map<String, ?> map) throws Exception {
            GetAuthInfoResponseBodyAuthUserInfo self = new GetAuthInfoResponseBodyAuthUserInfo();
            return TeaModel.build(map, self);
        }

        public GetAuthInfoResponseBodyAuthUserInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
