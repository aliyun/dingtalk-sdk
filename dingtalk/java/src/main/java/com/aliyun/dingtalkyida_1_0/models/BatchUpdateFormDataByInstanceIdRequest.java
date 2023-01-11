// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceIdRequest extends TeaModel {
    /**
     * <p>宜搭应用编码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>是否需要宜搭服务端异步执行该任务(选择异步执行那么OpenAPI调用会立即返回，并且任务会在宜搭服务端继续执行直至结束，且允许的单次更新数据量上限更大)</p>
     */
    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    /**
     * <p>表单实例id列表</p>
     */
    @NameInMap("formInstanceIdList")
    public java.util.List<String> formInstanceIdList;

    /**
     * <p>表单编码</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>是否忽略空值</p>
     */
    @NameInMap("ignoreEmpty")
    public Boolean ignoreEmpty;

    /**
     * <p>是否不触发校验规则、关联业务规则和第三方服务回调（如果您的业务无必要触发这些那么请填true以增大单次更新允许的数据量上限以及API的执行速度）</p>
     */
    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    /**
     * <p>宜搭应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>用于更新表单实例的数据, 格式为json字符串, 能解析成Map结构, 解析得到的Map的键为表单组件id, 值为表单组件值。详情参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31</p>
     */
    @NameInMap("updateFormDataJson")
    public String updateFormDataJson;

    /**
     * <p>是否使用最新的表单schema版本, 默认false</p>
     */
    @NameInMap("useLatestFormSchemaVersion")
    public Boolean useLatestFormSchemaVersion;

    /**
     * <p>钉钉userId</p>
     */
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
