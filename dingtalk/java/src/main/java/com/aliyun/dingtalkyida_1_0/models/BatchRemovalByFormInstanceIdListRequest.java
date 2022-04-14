// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchRemovalByFormInstanceIdListRequest extends TeaModel {
    // 宜搭应用编码
    @NameInMap("appType")
    public String appType;

    // 是否需要宜搭服务端异步执行该任务(选择异步执行删除操作，那么OpenAPI调用会立即返回，并且宜搭服务端会继续执行删除操作直至结束，且允许的单次删除数据量上限更大)
    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    // 是否需要触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填false以降低API的耗时以及获得更大的单次删除数据量上限）
    @NameInMap("executeExpression")
    public Boolean executeExpression;

    // 表单实例id列表
    @NameInMap("formInstanceIdList")
    public java.util.List<String> formInstanceIdList;

    // 表单编码
    @NameInMap("formUuid")
    public String formUuid;

    // 宜搭应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉userId
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
