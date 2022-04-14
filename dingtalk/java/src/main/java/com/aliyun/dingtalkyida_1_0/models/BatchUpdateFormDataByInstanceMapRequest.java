// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceMapRequest extends TeaModel {
    // 宜搭应用编码
    @NameInMap("appType")
    public String appType;

    // 该任务是否需要服务端异步执行(选择异步执行那么OpenAPI调用会立即返回并且任务在宜搭服务端继续执行，可支持更大的单次更新数据量上限)
    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    // 表单编码
    @NameInMap("formUuid")
    public String formUuid;

    // 是否忽略空值
    @NameInMap("ignoreEmpty")
    public Boolean ignoreEmpty;

    // 是否不需要触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填true以减小API的耗时以及更大的单次更新数据量上限）
    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    // 宜搭应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 表单实例数据, json字符串, 可以解析成Map, 解析后得到的Map的键是表单实例id, 值是表单实例更新值json字符串。具体结构请参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31
    @NameInMap("updateFormDataJsonMap")
    public java.util.Map<String, ?> updateFormDataJsonMap;

    // 是否使用最新的表单schema版本, 默认false
    @NameInMap("useLatestFormSchemaVersion")
    public Boolean useLatestFormSchemaVersion;

    // 钉钉userId
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
