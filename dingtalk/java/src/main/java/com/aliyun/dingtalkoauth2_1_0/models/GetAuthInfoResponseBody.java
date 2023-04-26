// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class GetAuthInfoResponseBody extends TeaModel {
    @NameInMap("authAppInfo")
    public GetAuthInfoResponseBodyAuthAppInfo authAppInfo;

    @NameInMap("authCorpInfo")
    public GetAuthInfoResponseBodyAuthCorpInfo authCorpInfo;

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
        @NameInMap("adminList")
        public java.util.List<String> adminList;

        @NameInMap("agentId")
        public Long agentId;

        @NameInMap("agentName")
        public String agentName;

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
        @NameInMap("authChannel")
        public String authChannel;

        @NameInMap("authChannelType")
        public String authChannelType;

        @NameInMap("authLevel")
        public Long authLevel;

        @NameInMap("corpLogoUrl")
        public String corpLogoUrl;

        @NameInMap("corpName")
        public String corpName;

        @NameInMap("industry")
        public String industry;

        @NameInMap("inviteCode")
        public String inviteCode;

        @NameInMap("inviteUrl")
        public String inviteUrl;

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
