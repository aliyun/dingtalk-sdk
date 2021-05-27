// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateProcessRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("initiatorUserId")
    public String initiatorUserId;

    @NameInMap("taskName")
    public String taskName;

    @NameInMap("signEndTime")
    public Long signEndTime;

    @NameInMap("redirectUrl")
    public String redirectUrl;

    @NameInMap("files")
    public java.util.List<CreateProcessRequestFiles> files;

    @NameInMap("participants")
    public java.util.List<CreateProcessRequestParticipants> participants;

    @NameInMap("ccs")
    public java.util.List<CreateProcessRequestCcs> ccs;

    @NameInMap("sourceInfo")
    public CreateProcessRequestSourceInfo sourceInfo;

    public static CreateProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateProcessRequest self = new CreateProcessRequest();
        return TeaModel.build(map, self);
    }

    public CreateProcessRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateProcessRequest setInitiatorUserId(String initiatorUserId) {
        this.initiatorUserId = initiatorUserId;
        return this;
    }
    public String getInitiatorUserId() {
        return this.initiatorUserId;
    }

    public CreateProcessRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

    public CreateProcessRequest setSignEndTime(Long signEndTime) {
        this.signEndTime = signEndTime;
        return this;
    }
    public Long getSignEndTime() {
        return this.signEndTime;
    }

    public CreateProcessRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public CreateProcessRequest setFiles(java.util.List<CreateProcessRequestFiles> files) {
        this.files = files;
        return this;
    }
    public java.util.List<CreateProcessRequestFiles> getFiles() {
        return this.files;
    }

    public CreateProcessRequest setParticipants(java.util.List<CreateProcessRequestParticipants> participants) {
        this.participants = participants;
        return this;
    }
    public java.util.List<CreateProcessRequestParticipants> getParticipants() {
        return this.participants;
    }

    public CreateProcessRequest setCcs(java.util.List<CreateProcessRequestCcs> ccs) {
        this.ccs = ccs;
        return this;
    }
    public java.util.List<CreateProcessRequestCcs> getCcs() {
        return this.ccs;
    }

    public CreateProcessRequest setSourceInfo(CreateProcessRequestSourceInfo sourceInfo) {
        this.sourceInfo = sourceInfo;
        return this;
    }
    public CreateProcessRequestSourceInfo getSourceInfo() {
        return this.sourceInfo;
    }

    public static class CreateProcessRequestFiles extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileType")
        public Integer fileType;

        @NameInMap("fileName")
        public String fileName;

        public static CreateProcessRequestFiles build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestFiles self = new CreateProcessRequestFiles();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestFiles setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateProcessRequestFiles setFileType(Integer fileType) {
            this.fileType = fileType;
            return this;
        }
        public Integer getFileType() {
            return this.fileType;
        }

        public CreateProcessRequestFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

    }

    public static class CreateProcessRequestParticipants extends TeaModel {
        @NameInMap("signRequirements")
        public String signRequirements;

        @NameInMap("signOrder")
        public Integer signOrder;

        @NameInMap("accountType")
        public String accountType;

        @NameInMap("account")
        public String account;

        @NameInMap("dingCorpId")
        public String dingCorpId;

        @NameInMap("userId")
        public String userId;

        @NameInMap("accountName")
        public String accountName;

        @NameInMap("orgName")
        public String orgName;

        public static CreateProcessRequestParticipants build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestParticipants self = new CreateProcessRequestParticipants();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestParticipants setSignRequirements(String signRequirements) {
            this.signRequirements = signRequirements;
            return this;
        }
        public String getSignRequirements() {
            return this.signRequirements;
        }

        public CreateProcessRequestParticipants setSignOrder(Integer signOrder) {
            this.signOrder = signOrder;
            return this;
        }
        public Integer getSignOrder() {
            return this.signOrder;
        }

        public CreateProcessRequestParticipants setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public CreateProcessRequestParticipants setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public CreateProcessRequestParticipants setDingCorpId(String dingCorpId) {
            this.dingCorpId = dingCorpId;
            return this;
        }
        public String getDingCorpId() {
            return this.dingCorpId;
        }

        public CreateProcessRequestParticipants setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CreateProcessRequestParticipants setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public CreateProcessRequestParticipants setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class CreateProcessRequestCcs extends TeaModel {
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("account")
        public String account;

        @NameInMap("dingCorpId")
        public String dingCorpId;

        @NameInMap("userId")
        public String userId;

        @NameInMap("accountName")
        public String accountName;

        @NameInMap("orgName")
        public String orgName;

        public static CreateProcessRequestCcs build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestCcs self = new CreateProcessRequestCcs();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestCcs setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public CreateProcessRequestCcs setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public CreateProcessRequestCcs setDingCorpId(String dingCorpId) {
            this.dingCorpId = dingCorpId;
            return this;
        }
        public String getDingCorpId() {
            return this.dingCorpId;
        }

        public CreateProcessRequestCcs setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CreateProcessRequestCcs setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public CreateProcessRequestCcs setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class CreateProcessRequestSourceInfo extends TeaModel {
        @NameInMap("showText")
        public String showText;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("mobileUrl")
        public String mobileUrl;

        public static CreateProcessRequestSourceInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestSourceInfo self = new CreateProcessRequestSourceInfo();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestSourceInfo setShowText(String showText) {
            this.showText = showText;
            return this;
        }
        public String getShowText() {
            return this.showText;
        }

        public CreateProcessRequestSourceInfo setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public CreateProcessRequestSourceInfo setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

    }

}
