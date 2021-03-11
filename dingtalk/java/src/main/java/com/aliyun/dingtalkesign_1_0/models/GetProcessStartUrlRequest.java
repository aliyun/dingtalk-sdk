// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetProcessStartUrlRequest extends TeaModel {
    @NameInMap("files")
    public java.util.List<GetProcessStartUrlRequestFiles> files;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("initiatorUserId")
    public String initiatorUserId;

    @NameInMap("participants")
    public java.util.List<GetProcessStartUrlRequestParticipants> participants;

    @NameInMap("redirectUrl")
    public String redirectUrl;

    @NameInMap("sourceInfo")
    public GetProcessStartUrlRequestSourceInfo sourceInfo;

    @NameInMap("taskName")
    public String taskName;

    @NameInMap("ccs")
    public java.util.List<GetProcessStartUrlRequestCcs> ccs;

    @NameInMap("dingIsvAccessToken")
    public String dingIsvAccessToken;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    public static GetProcessStartUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProcessStartUrlRequest self = new GetProcessStartUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetProcessStartUrlRequest setFiles(java.util.List<GetProcessStartUrlRequestFiles> files) {
        this.files = files;
        return this;
    }
    public java.util.List<GetProcessStartUrlRequestFiles> getFiles() {
        return this.files;
    }

    public GetProcessStartUrlRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public GetProcessStartUrlRequest setInitiatorUserId(String initiatorUserId) {
        this.initiatorUserId = initiatorUserId;
        return this;
    }
    public String getInitiatorUserId() {
        return this.initiatorUserId;
    }

    public GetProcessStartUrlRequest setParticipants(java.util.List<GetProcessStartUrlRequestParticipants> participants) {
        this.participants = participants;
        return this;
    }
    public java.util.List<GetProcessStartUrlRequestParticipants> getParticipants() {
        return this.participants;
    }

    public GetProcessStartUrlRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public GetProcessStartUrlRequest setSourceInfo(GetProcessStartUrlRequestSourceInfo sourceInfo) {
        this.sourceInfo = sourceInfo;
        return this;
    }
    public GetProcessStartUrlRequestSourceInfo getSourceInfo() {
        return this.sourceInfo;
    }

    public GetProcessStartUrlRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

    public GetProcessStartUrlRequest setCcs(java.util.List<GetProcessStartUrlRequestCcs> ccs) {
        this.ccs = ccs;
        return this;
    }
    public java.util.List<GetProcessStartUrlRequestCcs> getCcs() {
        return this.ccs;
    }

    public GetProcessStartUrlRequest setDingIsvAccessToken(String dingIsvAccessToken) {
        this.dingIsvAccessToken = dingIsvAccessToken;
        return this;
    }
    public String getDingIsvAccessToken() {
        return this.dingIsvAccessToken;
    }

    public GetProcessStartUrlRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public static class GetProcessStartUrlRequestFiles extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        public static GetProcessStartUrlRequestFiles build(java.util.Map<String, ?> map) throws Exception {
            GetProcessStartUrlRequestFiles self = new GetProcessStartUrlRequestFiles();
            return TeaModel.build(map, self);
        }

        public GetProcessStartUrlRequestFiles setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public GetProcessStartUrlRequestFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

    }

    public static class GetProcessStartUrlRequestParticipants extends TeaModel {
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("dingCorpId")
        public String dingCorpId;

        @NameInMap("signRequirements")
        public String signRequirements;

        @NameInMap("userId")
        public String userId;

        @NameInMap("account")
        public String account;

        @NameInMap("accountName")
        public String accountName;

        @NameInMap("orgName")
        public String orgName;

        public static GetProcessStartUrlRequestParticipants build(java.util.Map<String, ?> map) throws Exception {
            GetProcessStartUrlRequestParticipants self = new GetProcessStartUrlRequestParticipants();
            return TeaModel.build(map, self);
        }

        public GetProcessStartUrlRequestParticipants setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public GetProcessStartUrlRequestParticipants setDingCorpId(String dingCorpId) {
            this.dingCorpId = dingCorpId;
            return this;
        }
        public String getDingCorpId() {
            return this.dingCorpId;
        }

        public GetProcessStartUrlRequestParticipants setSignRequirements(String signRequirements) {
            this.signRequirements = signRequirements;
            return this;
        }
        public String getSignRequirements() {
            return this.signRequirements;
        }

        public GetProcessStartUrlRequestParticipants setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetProcessStartUrlRequestParticipants setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public GetProcessStartUrlRequestParticipants setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public GetProcessStartUrlRequestParticipants setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class GetProcessStartUrlRequestSourceInfo extends TeaModel {
        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("showText")
        public String showText;

        public static GetProcessStartUrlRequestSourceInfo build(java.util.Map<String, ?> map) throws Exception {
            GetProcessStartUrlRequestSourceInfo self = new GetProcessStartUrlRequestSourceInfo();
            return TeaModel.build(map, self);
        }

        public GetProcessStartUrlRequestSourceInfo setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public GetProcessStartUrlRequestSourceInfo setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public GetProcessStartUrlRequestSourceInfo setShowText(String showText) {
            this.showText = showText;
            return this;
        }
        public String getShowText() {
            return this.showText;
        }

    }

    public static class GetProcessStartUrlRequestCcs extends TeaModel {
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("dingCorpId")
        public String dingCorpId;

        @NameInMap("userId")
        public String userId;

        @NameInMap("account")
        public String account;

        @NameInMap("accountName")
        public String accountName;

        @NameInMap("orgName")
        public String orgName;

        public static GetProcessStartUrlRequestCcs build(java.util.Map<String, ?> map) throws Exception {
            GetProcessStartUrlRequestCcs self = new GetProcessStartUrlRequestCcs();
            return TeaModel.build(map, self);
        }

        public GetProcessStartUrlRequestCcs setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public GetProcessStartUrlRequestCcs setDingCorpId(String dingCorpId) {
            this.dingCorpId = dingCorpId;
            return this;
        }
        public String getDingCorpId() {
            return this.dingCorpId;
        }

        public GetProcessStartUrlRequestCcs setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetProcessStartUrlRequestCcs setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public GetProcessStartUrlRequestCcs setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public GetProcessStartUrlRequestCcs setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

}
