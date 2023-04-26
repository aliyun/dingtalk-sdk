// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceMapRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    @NameInMap("formUuid")
    public String formUuid;

    @NameInMap("ignoreEmpty")
    public Boolean ignoreEmpty;

    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("updateFormDataJsonMap")
    public java.util.Map<String, ?> updateFormDataJsonMap;

    @NameInMap("useLatestFormSchemaVersion")
    public Boolean useLatestFormSchemaVersion;

    @NameInMap("userId")
    public String userId;

    public static BatchUpdateFormDataByInstanceMapRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateFormDataByInstanceMapRequest self = new BatchUpdateFormDataByInstanceMapRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateFormDataByInstanceMapRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public BatchUpdateFormDataByInstanceMapRequest setAsynchronousExecution(Boolean asynchronousExecution) {
        this.asynchronousExecution = asynchronousExecution;
        return this;
    }
    public Boolean getAsynchronousExecution() {
        return this.asynchronousExecution;
    }

    public BatchUpdateFormDataByInstanceMapRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public BatchUpdateFormDataByInstanceMapRequest setIgnoreEmpty(Boolean ignoreEmpty) {
        this.ignoreEmpty = ignoreEmpty;
        return this;
    }
    public Boolean getIgnoreEmpty() {
        return this.ignoreEmpty;
    }

    public BatchUpdateFormDataByInstanceMapRequest setNoExecuteExpression(Boolean noExecuteExpression) {
        this.noExecuteExpression = noExecuteExpression;
        return this;
    }
    public Boolean getNoExecuteExpression() {
        return this.noExecuteExpression;
    }

    public BatchUpdateFormDataByInstanceMapRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public BatchUpdateFormDataByInstanceMapRequest setUpdateFormDataJsonMap(java.util.Map<String, ?> updateFormDataJsonMap) {
        this.updateFormDataJsonMap = updateFormDataJsonMap;
        return this;
    }
    public java.util.Map<String, ?> getUpdateFormDataJsonMap() {
        return this.updateFormDataJsonMap;
    }

    public BatchUpdateFormDataByInstanceMapRequest setUseLatestFormSchemaVersion(Boolean useLatestFormSchemaVersion) {
        this.useLatestFormSchemaVersion = useLatestFormSchemaVersion;
        return this;
    }
    public Boolean getUseLatestFormSchemaVersion() {
        return this.useLatestFormSchemaVersion;
    }

    public BatchUpdateFormDataByInstanceMapRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
