// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchRemovalByFormInstanceIdListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appType")
    public String appType;

    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    @NameInMap("executeExpression")
    public Boolean executeExpression;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formInstanceIdList")
    public java.util.List<String> formInstanceIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BatchRemovalByFormInstanceIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchRemovalByFormInstanceIdListRequest self = new BatchRemovalByFormInstanceIdListRequest();
        return TeaModel.build(map, self);
    }

    public BatchRemovalByFormInstanceIdListRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public BatchRemovalByFormInstanceIdListRequest setAsynchronousExecution(Boolean asynchronousExecution) {
        this.asynchronousExecution = asynchronousExecution;
        return this;
    }
    public Boolean getAsynchronousExecution() {
        return this.asynchronousExecution;
    }

    public BatchRemovalByFormInstanceIdListRequest setExecuteExpression(Boolean executeExpression) {
        this.executeExpression = executeExpression;
        return this;
    }
    public Boolean getExecuteExpression() {
        return this.executeExpression;
    }

    public BatchRemovalByFormInstanceIdListRequest setFormInstanceIdList(java.util.List<String> formInstanceIdList) {
        this.formInstanceIdList = formInstanceIdList;
        return this;
    }
    public java.util.List<String> getFormInstanceIdList() {
        return this.formInstanceIdList;
    }

    public BatchRemovalByFormInstanceIdListRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public BatchRemovalByFormInstanceIdListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public BatchRemovalByFormInstanceIdListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
