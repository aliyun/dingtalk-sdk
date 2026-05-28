// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetPublishAuditResponseBody extends TeaModel {
    @NameInMap("audit")
    public GetPublishAuditResponseBodyAudit audit;

    public static GetPublishAuditResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPublishAuditResponseBody self = new GetPublishAuditResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPublishAuditResponseBody setAudit(GetPublishAuditResponseBodyAudit audit) {
        this.audit = audit;
        return this;
    }
    public GetPublishAuditResponseBodyAudit getAudit() {
        return this.audit;
    }

    public static class GetPublishAuditResponseBodyAudit extends TeaModel {
        @NameInMap("agentId")
        public String agentId;

        @NameInMap("appIcon")
        public String appIcon;

        @NameInMap("appName")
        public String appName;

        @NameInMap("approvalContent")
        public String approvalContent;

        @NameInMap("auditId")
        public String auditId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("releaseNote")
        public String releaseNote;

        @NameInMap("sceneType")
        public Long sceneType;

        @NameInMap("status")
        public Long status;

        @NameInMap("submitTime")
        public String submitTime;

        @NameInMap("version")
        public String version;

        @NameInMap("versionDetailUrl")
        public String versionDetailUrl;

        @NameInMap("versionId")
        public String versionId;

        public static GetPublishAuditResponseBodyAudit build(java.util.Map<String, ?> map) throws Exception {
            GetPublishAuditResponseBodyAudit self = new GetPublishAuditResponseBodyAudit();
            return TeaModel.build(map, self);
        }

        public GetPublishAuditResponseBodyAudit setAgentId(String agentId) {
            this.agentId = agentId;
            return this;
        }
        public String getAgentId() {
            return this.agentId;
        }

        public GetPublishAuditResponseBodyAudit setAppIcon(String appIcon) {
            this.appIcon = appIcon;
            return this;
        }
        public String getAppIcon() {
            return this.appIcon;
        }

        public GetPublishAuditResponseBodyAudit setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public GetPublishAuditResponseBodyAudit setApprovalContent(String approvalContent) {
            this.approvalContent = approvalContent;
            return this;
        }
        public String getApprovalContent() {
            return this.approvalContent;
        }

        public GetPublishAuditResponseBodyAudit setAuditId(String auditId) {
            this.auditId = auditId;
            return this;
        }
        public String getAuditId() {
            return this.auditId;
        }

        public GetPublishAuditResponseBodyAudit setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetPublishAuditResponseBodyAudit setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetPublishAuditResponseBodyAudit setReleaseNote(String releaseNote) {
            this.releaseNote = releaseNote;
            return this;
        }
        public String getReleaseNote() {
            return this.releaseNote;
        }

        public GetPublishAuditResponseBodyAudit setSceneType(Long sceneType) {
            this.sceneType = sceneType;
            return this;
        }
        public Long getSceneType() {
            return this.sceneType;
        }

        public GetPublishAuditResponseBodyAudit setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public GetPublishAuditResponseBodyAudit setSubmitTime(String submitTime) {
            this.submitTime = submitTime;
            return this;
        }
        public String getSubmitTime() {
            return this.submitTime;
        }

        public GetPublishAuditResponseBodyAudit setVersion(String version) {
            this.version = version;
            return this;
        }
        public String getVersion() {
            return this.version;
        }

        public GetPublishAuditResponseBodyAudit setVersionDetailUrl(String versionDetailUrl) {
            this.versionDetailUrl = versionDetailUrl;
            return this;
        }
        public String getVersionDetailUrl() {
            return this.versionDetailUrl;
        }

        public GetPublishAuditResponseBodyAudit setVersionId(String versionId) {
            this.versionId = versionId;
            return this;
        }
        public String getVersionId() {
            return this.versionId;
        }

    }

}
