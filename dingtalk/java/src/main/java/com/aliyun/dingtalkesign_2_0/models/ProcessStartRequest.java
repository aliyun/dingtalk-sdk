// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ProcessStartRequest extends TeaModel {
    /**
     * <p>是否自动发起</p>
     */
    @NameInMap("autoStart")
    public String autoStart;

    /**
     * <p>抄送人列表</p>
     */
    @NameInMap("ccs")
    public java.util.List<ProcessStartRequestCcs> ccs;

    /**
     * <p>文件列表</p>
     */
    @NameInMap("files")
    public java.util.List<ProcessStartRequestFiles> files;

    /**
     * <p>发起方userId</p>
     */
    @NameInMap("initiatorUserId")
    public String initiatorUserId;

    /**
     * <p>参与方列表</p>
     */
    @NameInMap("participants")
    public java.util.List<ProcessStartRequestParticipants> participants;

    /**
     * <p>回跳地址</p>
     */
    @NameInMap("redirectUrl")
    public String redirectUrl;

    /**
     * <p>来源信息(目前支持传入审批信息和跳转地址)</p>
     */
    @NameInMap("sourceInfo")
    public ProcessStartRequestSourceInfo sourceInfo;

    /**
     * <p>任务名称（默认文件名）</p>
     */
    @NameInMap("taskName")
    public String taskName;

    public static ProcessStartRequest build(java.util.Map<String, ?> map) throws Exception {
        ProcessStartRequest self = new ProcessStartRequest();
        return TeaModel.build(map, self);
    }

    public ProcessStartRequest setAutoStart(String autoStart) {
        this.autoStart = autoStart;
        return this;
    }
    public String getAutoStart() {
        return this.autoStart;
    }

    public ProcessStartRequest setCcs(java.util.List<ProcessStartRequestCcs> ccs) {
        this.ccs = ccs;
        return this;
    }
    public java.util.List<ProcessStartRequestCcs> getCcs() {
        return this.ccs;
    }

    public ProcessStartRequest setFiles(java.util.List<ProcessStartRequestFiles> files) {
        this.files = files;
        return this;
    }
    public java.util.List<ProcessStartRequestFiles> getFiles() {
        return this.files;
    }

    public ProcessStartRequest setInitiatorUserId(String initiatorUserId) {
        this.initiatorUserId = initiatorUserId;
        return this;
    }
    public String getInitiatorUserId() {
        return this.initiatorUserId;
    }

    public ProcessStartRequest setParticipants(java.util.List<ProcessStartRequestParticipants> participants) {
        this.participants = participants;
        return this;
    }
    public java.util.List<ProcessStartRequestParticipants> getParticipants() {
        return this.participants;
    }

    public ProcessStartRequest setRedirectUrl(String redirectUrl) {
        this.redirectUrl = redirectUrl;
        return this;
    }
    public String getRedirectUrl() {
        return this.redirectUrl;
    }

    public ProcessStartRequest setSourceInfo(ProcessStartRequestSourceInfo sourceInfo) {
        this.sourceInfo = sourceInfo;
        return this;
    }
    public ProcessStartRequestSourceInfo getSourceInfo() {
        return this.sourceInfo;
    }

    public ProcessStartRequest setTaskName(String taskName) {
        this.taskName = taskName;
        return this;
    }
    public String getTaskName() {
        return this.taskName;
    }

    public static class ProcessStartRequestCcs extends TeaModel {
        /**
         * <p>OUTER_USER必填</p>
         */
        @NameInMap("account")
        public String account;

        /**
         * <p>OUTER_USER必填</p>
         */
        @NameInMap("accountName")
        public String accountName;

        /**
         * <p>用户类型（"DING_USER":钉钉用户，"OUTER_USER":外部用户）</p>
         */
        @NameInMap("accountType")
        public String accountType;

        /**
         * <p>发给企业方必填</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <p>DING_USER必填</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ProcessStartRequestCcs build(java.util.Map<String, ?> map) throws Exception {
            ProcessStartRequestCcs self = new ProcessStartRequestCcs();
            return TeaModel.build(map, self);
        }

        public ProcessStartRequestCcs setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public ProcessStartRequestCcs setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public ProcessStartRequestCcs setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public ProcessStartRequestCcs setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public ProcessStartRequestCcs setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ProcessStartRequestFiles extends TeaModel {
        @NameInMap("fileId")
        public String fileId;

        @NameInMap("fileName")
        public String fileName;

        public static ProcessStartRequestFiles build(java.util.Map<String, ?> map) throws Exception {
            ProcessStartRequestFiles self = new ProcessStartRequestFiles();
            return TeaModel.build(map, self);
        }

        public ProcessStartRequestFiles setFileId(String fileId) {
            this.fileId = fileId;
            return this;
        }
        public String getFileId() {
            return this.fileId;
        }

        public ProcessStartRequestFiles setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

    }

    public static class ProcessStartRequestParticipants extends TeaModel {
        /**
         * <p>OUTER_USER必填</p>
         */
        @NameInMap("account")
        public String account;

        /**
         * <p>OUTER_USER必填</p>
         */
        @NameInMap("accountName")
        public String accountName;

        /**
         * <p>用户类型（"DING_USER":钉钉用户，"OUTER_USER":外部用户）</p>
         */
        @NameInMap("accountType")
        public String accountType;

        /**
         * <p>OUTER_USER需要盖企业章必填(如果不传，默认会赋值当前企业名称)</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <p>签署印章类型（1：企业章 2：个人章  1,2：个人和企业章）</p>
         */
        @NameInMap("signRequirements")
        public String signRequirements;

        /**
         * <p>DING_USER必填</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ProcessStartRequestParticipants build(java.util.Map<String, ?> map) throws Exception {
            ProcessStartRequestParticipants self = new ProcessStartRequestParticipants();
            return TeaModel.build(map, self);
        }

        public ProcessStartRequestParticipants setAccount(String account) {
            this.account = account;
            return this;
        }
        public String getAccount() {
            return this.account;
        }

        public ProcessStartRequestParticipants setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

        public ProcessStartRequestParticipants setAccountType(String accountType) {
            this.accountType = accountType;
            return this;
        }
        public String getAccountType() {
            return this.accountType;
        }

        public ProcessStartRequestParticipants setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public ProcessStartRequestParticipants setSignRequirements(String signRequirements) {
            this.signRequirements = signRequirements;
            return this;
        }
        public String getSignRequirements() {
            return this.signRequirements;
        }

        public ProcessStartRequestParticipants setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ProcessStartRequestSourceInfo extends TeaModel {
        /**
         * <p>移动端跳转地址</p>
         */
        @NameInMap("mobileUrl")
        public String mobileUrl;

        /**
         * <p>pc端跳转地址</p>
         */
        @NameInMap("pcUrl")
        public String pcUrl;

        /**
         * <p>展示文案</p>
         */
        @NameInMap("showText")
        public String showText;

        public static ProcessStartRequestSourceInfo build(java.util.Map<String, ?> map) throws Exception {
            ProcessStartRequestSourceInfo self = new ProcessStartRequestSourceInfo();
            return TeaModel.build(map, self);
        }

        public ProcessStartRequestSourceInfo setMobileUrl(String mobileUrl) {
            this.mobileUrl = mobileUrl;
            return this;
        }
        public String getMobileUrl() {
            return this.mobileUrl;
        }

        public ProcessStartRequestSourceInfo setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public ProcessStartRequestSourceInfo setShowText(String showText) {
            this.showText = showText;
            return this;
        }
        public String getShowText() {
            return this.showText;
        }

    }

}
