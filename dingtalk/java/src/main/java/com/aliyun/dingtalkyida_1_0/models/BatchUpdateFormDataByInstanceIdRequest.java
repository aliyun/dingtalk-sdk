// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceIdRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    @NameInMap("formInstanceIdList")
    public java.util.List<String> formInstanceIdList;

    @NameInMap("formUuid")
    public String formUuid;

    @NameInMap("ignoreEmpty")
    public Boolean ignoreEmpty;

    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("updateFormDataJson")
    public String updateFormDataJson;

    @NameInMap("useLatestFormSchemaVersion")
    public Boolean useLatestFormSchemaVersion;

    @NameInMap("userId")
    public String userId;

    public static BatchUpdateFormDataByInstanceIdRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFormDataByInstanceIdRequest self = new BatchUpdateFormDataByInstanceIdRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFormDataByInstanceIdRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public BatchUpdateFormDataByInstanceIdRequest setAsynchronousExecution(Boolean asynchronousExecution) {
        this.asynchronousExecution = asynchronousExecution;
        return this;
    }
    public Boolean getAsynchronousExecution() {
        return this.asynchronousExecution;
    }

    public BatchUpdateFormDataByInstanceIdRequest setFormInstanceIdList(java.util.List<String> formInstanceIdList) {
        this.formInstanceIdList = formInstanceIdList;
        return this;
    }
    public java.util.List<String> getFormInstanceIdList() {
        return this.formInstanceIdList;
    }

    public BatchUpdateFormDataByInstanceIdRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public BatchUpdateFormDataByInstanceIdRequest setIgnoreEmpty(Boolean ignoreEmpty) {
        this.ignoreEmpty = ignoreEmpty;
        return this;
    }
    public Boolean getIgnoreEmpty() {
        return this.ignoreEmpty;
    }

    public BatchUpdateFormDataByInstanceIdRequest setNoExecuteExpression(Boolean noExecuteExpression) {
        this.noExecuteExpression = noExecuteExpression;
        return this;
    }
    public Boolean getNoExecuteExpression() {
        return this.noExecuteExpression;
    }

    public BatchUpdateFormDataByInstanceIdRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public BatchUpdateFormDataByInstanceIdRequest setUpdateFormDataJson(String updateFormDataJson) {
        this.updateFormDataJson = updateFormDataJson;
        return this;
    }
    public String getUpdateFormDataJson() {
        return this.updateFormDataJson;
    }

    public BatchUpdateFormDataByInstanceIdRequest setUseLatestFormSchemaVersion(Boolean useLatestFormSchemaVersion) {
        this.useLatestFormSchemaVersion = useLatestFormSchemaVersion;
        return this;
    }
    public Boolean getUseLatestFormSchemaVersion() {
        return this.useLatestFormSchemaVersion;
    }

    public BatchUpdateFormDataByInstanceIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
