// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateTitleAuditStatusRequest extends TeaModel {
    @NameInMap("authStatus")
    public String authStatus;

    @NameInMap("educationLevel")
    public String educationLevel;

    @NameInMap("extension")
    public String extension;

    @NameInMap("major")
    public String major;

    @NameInMap("position")
    public String position;

    @NameInMap("reasonCode")
    public String reasonCode;

    @NameInMap("reasonMsg")
    public String reasonMsg;

    @NameInMap("school")
    public String school;

    @NameInMap("type")
    public String type;

    @NameInMap("unionId")
    public String unionId;

    @NameInMap("uuid")
    public String uuid;

    public static UpdateTitleAuditStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTitleAuditStatusRequest self = new UpdateTitleAuditStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTitleAuditStatusRequest setAuthStatus(String authStatus) {
        this.authStatus = authStatus;
        return this;
    }
    public String getAuthStatus() {
        return this.authStatus;
    }

    public UpdateTitleAuditStatusRequest setEducationLevel(String educationLevel) {
        this.educationLevel = educationLevel;
        return this;
    }
    public String getEducationLevel() {
        return this.educationLevel;
    }

    public UpdateTitleAuditStatusRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public UpdateTitleAuditStatusRequest setMajor(String major) {
        this.major = major;
        return this;
    }
    public String getMajor() {
        return this.major;
    }

    public UpdateTitleAuditStatusRequest setPosition(String position) {
        this.position = position;
        return this;
    }
    public String getPosition() {
        return this.position;
    }

    public UpdateTitleAuditStatusRequest setReasonCode(String reasonCode) {
        this.reasonCode = reasonCode;
        return this;
    }
    public String getReasonCode() {
        return this.reasonCode;
    }

    public UpdateTitleAuditStatusRequest setReasonMsg(String reasonMsg) {
        this.reasonMsg = reasonMsg;
        return this;
    }
    public String getReasonMsg() {
        return this.reasonMsg;
    }

    public UpdateTitleAuditStatusRequest setSchool(String school) {
        this.school = school;
        return this;
    }
    public String getSchool() {
        return this.school;
    }

    public UpdateTitleAuditStatusRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public UpdateTitleAuditStatusRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public UpdateTitleAuditStatusRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
