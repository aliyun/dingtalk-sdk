// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncProjectRequest extends TeaModel {
    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("code")
    public String code;

    @NameInMap("costCenterId")
    public String costCenterId;

    @NameInMap("deleteFlag")
    public Boolean deleteFlag;

    @NameInMap("extension")
    public String extension;

    @NameInMap("gmtAction")
    public String gmtAction;

    @NameInMap("invoiceId")
    public String invoiceId;

    @NameInMap("managerIds")
    public java.util.List<String> managerIds;

    @NameInMap("projectId")
    public String projectId;

    @NameInMap("projectName")
    public String projectName;

    @NameInMap("source")
    public String source;

    @NameInMap("thirdPartId")
    public String thirdPartId;

    @NameInMap("userId")
    public String userId;

    public static SyncProjectRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncProjectRequest self = new SyncProjectRequest();
        return TeaModel.build(map, self);
    }

    public SyncProjectRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public SyncProjectRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public SyncProjectRequest setCostCenterId(String costCenterId) {
        this.costCenterId = costCenterId;
        return this;
    }
    public String getCostCenterId() {
        return this.costCenterId;
    }

    public SyncProjectRequest setDeleteFlag(Boolean deleteFlag) {
        this.deleteFlag = deleteFlag;
        return this;
    }
    public Boolean getDeleteFlag() {
        return this.deleteFlag;
    }

    public SyncProjectRequest setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public SyncProjectRequest setGmtAction(String gmtAction) {
        this.gmtAction = gmtAction;
        return this;
    }
    public String getGmtAction() {
        return this.gmtAction;
    }

    public SyncProjectRequest setInvoiceId(String invoiceId) {
        this.invoiceId = invoiceId;
        return this;
    }
    public String getInvoiceId() {
        return this.invoiceId;
    }

    public SyncProjectRequest setManagerIds(java.util.List<String> managerIds) {
        this.managerIds = managerIds;
        return this;
    }
    public java.util.List<String> getManagerIds() {
        return this.managerIds;
    }

    public SyncProjectRequest setProjectId(String projectId) {
        this.projectId = projectId;
        return this;
    }
    public String getProjectId() {
        return this.projectId;
    }

    public SyncProjectRequest setProjectName(String projectName) {
        this.projectName = projectName;
        return this;
    }
    public String getProjectName() {
        return this.projectName;
    }

    public SyncProjectRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public SyncProjectRequest setThirdPartId(String thirdPartId) {
        this.thirdPartId = thirdPartId;
        return this;
    }
    public String getThirdPartId() {
        return this.thirdPartId;
    }

    public SyncProjectRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
