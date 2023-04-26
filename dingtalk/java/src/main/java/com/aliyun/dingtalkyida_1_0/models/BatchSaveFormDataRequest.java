// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchSaveFormDataRequest extends TeaModel {
    @NameInMap("appType")
    public String appType;

    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    @NameInMap("formDataJsonList")
    public java.util.List<String> formDataJsonList;

    @NameInMap("formUuid")
    public String formUuid;

    @NameInMap("keepRunningAfterException")
    public Boolean keepRunningAfterException;

    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    @NameInMap("systemToken")
    public String systemToken;

    @NameInMap("userId")
    public String userId;

    public static BatchSaveFormDataRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchSaveFormDataRequest self = new BatchSaveFormDataRequest();
        return TeaModel.build(map, self);
    }

    public BatchSaveFormDataRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public BatchSaveFormDataRequest setAsynchronousExecution(Boolean asynchronousExecution) {
        this.asynchronousExecution = asynchronousExecution;
        return this;
    }
    public Boolean getAsynchronousExecution() {
        return this.asynchronousExecution;
    }

    public BatchSaveFormDataRequest setFormDataJsonList(java.util.List<String> formDataJsonList) {
        this.formDataJsonList = formDataJsonList;
        return this;
    }
    public java.util.List<String> getFormDataJsonList() {
        return this.formDataJsonList;
    }

    public BatchSaveFormDataRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public BatchSaveFormDataRequest setKeepRunningAfterException(Boolean keepRunningAfterException) {
        this.keepRunningAfterException = keepRunningAfterException;
        return this;
    }
    public Boolean getKeepRunningAfterException() {
        return this.keepRunningAfterException;
    }

    public BatchSaveFormDataRequest setNoExecuteExpression(Boolean noExecuteExpression) {
        this.noExecuteExpression = noExecuteExpression;
        return this;
    }
    public Boolean getNoExecuteExpression() {
        return this.noExecuteExpression;
    }

    public BatchSaveFormDataRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public BatchSaveFormDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
