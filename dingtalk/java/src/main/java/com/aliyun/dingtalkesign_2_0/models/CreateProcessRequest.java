// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class CreateProcessRequest extends TeaModel {
    @NameInMap("ccs")
    public java.util.List<CreateProcessRequestCcs> ccs;

    @NameInMap("files")
    public java.util.List<CreateProcessRequestFiles> files;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("initiatorUserId")
    public String initiatorUserId;

    @NameInMap("participants")
    public java.util.List<CreateProcessRequestParticipants> participants;

    @NameInMap("redirectUrl")
    public String redirectUrl;

    @NameInMap("signEndTime")
    public Long signEndTime;

    @NameInMap("sourceInfo")
    public CreateProcessRequestSourceInfo sourceInfo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskName")
    public String taskName;

    public static CreateProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateProcessRequest self = new CreateProcessRequest();
        return TeaModel.build(map, self);
    }

    public CreateProcessRequest setCcs(java.util.List<CreateProcessRequestCcs> ccs) {
        this.ccs = ccs;
        return this;
    }
    public java.util.List<CreateProcessRequestCcs> getCcs() {
        return this.ccs;
    }

    public CreateProcessRequest setFiles(java.util.List<CreateProcessRequestFiles> files) {
        this.files = files;
        return this;
    }
    public java.util.List<CreateProcessRequestFiles> getFiles() {
        return this.files;
    }

    public CreateProcessRequest setInitiatorUserId(String initiatorUserId) {
        this.initiatorUserId = initiatorUserId;
        return this;
    }
    public String getInitiatorUserId() {
        return this.initiatorUserId;
    }

    public CreateProcessRequest setParticipants(java.util.List<CreateProcessRequestParticipants> participants) {
        this.participants = participants;
        return this;
    }
    public java.util.List<CreateProcessRequestParticipants> getParticipants() {
        return this.participants;
    }

    public CreateProcessRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public CreateProcessRequest setSignEndTime(Long signEndTime) {
        this.signEndTime = signEndTime;
        return this;
    }
    public Long getSignEndTime() {
        return this.signEndTime;
    }

    public CreateProcessRequest setSourceInfo(CreateProcessRequestSourceInfo sourceInfo) {
        this.sourceInfo = sourceInfo;
        return this;
    }
    public CreateProcessRequestSourceInfo getSourceInfo() {
        return this.sourceInfo;
    }

    public CreateProcessRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

    public static class CreateProcessRequestCcs extends TeaModel {
        @NameInMap("account")
        public String account;

        @NameInMap("accountName")
        public String accountName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("userId")
        public String userId;

        public static CreateProcessRequestCcs build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestCcs self = new CreateProcessRequestCcs();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestCcs setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public CreateProcessRequestCcs setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public CreateProcessRequestCcs setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public CreateProcessRequestCcs setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public CreateProcessRequestCcs setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateProcessRequestFiles extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fileId")
        public String fileId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fileType")
        public Integer fileType;

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

        public CreateProcessRequestFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CreateProcessRequestFiles setFileType(Integer fileType) {
            this.fileType = fileType;
            return this;
        }
        public Integer getFileType() {
            return this.fileType;
        }

    }

    public static class CreateProcessRequestParticipantsSignPosListSignDate extends TeaModel {
        @NameInMap("format")
        public String format;

        public static CreateProcessRequestParticipantsSignPosListSignDate build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestParticipantsSignPosListSignDate self = new CreateProcessRequestParticipantsSignPosListSignDate();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestParticipantsSignPosListSignDate setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

    }

    public static class CreateProcessRequestParticipantsSignPosList extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("isCrossPage")
        public Boolean isCrossPage;

        @NameInMap("needSignDate")
        public Boolean needSignDate;

        @NameInMap("page")
        public String page;

        @NameInMap("signDate")
        public CreateProcessRequestParticipantsSignPosListSignDate signDate;

        @NameInMap("signRequirement")
        public String signRequirement;

        @NameInMap("x")
        public Double x;

        @NameInMap("y")
        public Double y;

        public static CreateProcessRequestParticipantsSignPosList build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestParticipantsSignPosList self = new CreateProcessRequestParticipantsSignPosList();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestParticipantsSignPosList setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public CreateProcessRequestParticipantsSignPosList setIsCrossPage(Boolean isCrossPage) {
            this.isCrossPage = isCrossPage;
            return this;
        }
        public Boolean getIsCrossPage() {
            return this.isCrossPage;
        }

        public CreateProcessRequestParticipantsSignPosList setNeedSignDate(Boolean needSignDate) {
            this.needSignDate = needSignDate;
            return this;
        }
        public Boolean getNeedSignDate() {
            return this.needSignDate;
        }

        public CreateProcessRequestParticipantsSignPosList setPage(String page) {
            this.page = page;
            return this;
        }
        public String getPage() {
            return this.page;
        }

        public CreateProcessRequestParticipantsSignPosList setSignDate(CreateProcessRequestParticipantsSignPosListSignDate signDate) {
            this.signDate = signDate;
            return this;
        }
        public CreateProcessRequestParticipantsSignPosListSignDate getSignDate() {
            return this.signDate;
        }

        public CreateProcessRequestParticipantsSignPosList setSignRequirement(String signRequirement) {
            this.signRequirement = signRequirement;
            return this;
        }
        public String getSignRequirement() {
            return this.signRequirement;
        }

        public CreateProcessRequestParticipantsSignPosList setX(Double x) {
            this.x = x;
            return this;
        }
        public Double getX() {
            return this.x;
        }

        public CreateProcessRequestParticipantsSignPosList setY(Double y) {
            this.y = y;
            return this;
        }
        public Double getY() {
            return this.y;
        }

    }

    public static class CreateProcessRequestParticipants extends TeaModel {
        @NameInMap("account")
        public String account;

        @NameInMap("accountName")
        public String accountName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("accountType")
        public String accountType;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("signOrder")
        public Integer signOrder;

        @NameInMap("signPosList")
        public java.util.List<CreateProcessRequestParticipantsSignPosList> signPosList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("signRequirements")
        public String signRequirements;

        @NameInMap("userId")
        public String userId;

        public static CreateProcessRequestParticipants build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestParticipants self = new CreateProcessRequestParticipants();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestParticipants setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public CreateProcessRequestParticipants setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public CreateProcessRequestParticipants setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public CreateProcessRequestParticipants setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public CreateProcessRequestParticipants setSignOrder(Integer signOrder) {
            this.signOrder = signOrder;
            return this;
        }
        public Integer getSignOrder() {
            return this.signOrder;
        }

        public CreateProcessRequestParticipants setSignPosList(java.util.List<CreateProcessRequestParticipantsSignPosList> signPosList) {
            this.signPosList = signPosList;
            return this;
        }
        public java.util.List<CreateProcessRequestParticipantsSignPosList> getSignPosList() {
            return this.signPosList;
        }

        public CreateProcessRequestParticipants setSignRequirements(String signRequirements) {
            this.signRequirements = signRequirements;
            return this;
        }
        public String getSignRequirements() {
            return this.signRequirements;
        }

        public CreateProcessRequestParticipants setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateProcessRequestSourceInfo extends TeaModel {
        @NameInMap("mobileUrl")
        public String mobileUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("showText")
        public String showText;

        public static CreateProcessRequestSourceInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessRequestSourceInfo self = new CreateProcessRequestSourceInfo();
            return TeaModel.build(map, self);
        }

        public CreateProcessRequestSourceInfo setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public CreateProcessRequestSourceInfo setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public CreateProcessRequestSourceInfo setShowText(String showText) {
            this.showText = showText;
            return this;
        }
        public String getShowText() {
            return this.showText;
        }

    }

}
