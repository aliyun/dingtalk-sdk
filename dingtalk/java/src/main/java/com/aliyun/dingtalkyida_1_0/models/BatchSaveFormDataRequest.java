// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchSaveFormDataRequest extends TeaModel {
    /**
     * <p>宜搭应用编码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>是否需要宜搭服务端异步执行该任务(如果选择异步创建表单实例，那么OpenAPI调用会立即返回，并且宜搭服务端会继续执行保存操作直至结束，且允许的单次保存数据量上限更大)</p>
     */
    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    /**
     * <p>表单实例数据列表。表单实例数据的结构请参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31</p>
     */
    @NameInMap("formDataJsonList")
    public java.util.List<String> formDataJsonList;

    /**
     * <p>表单编码</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>批量保存多条表单实例数据发生异常时是否跳过异常的表单实例并继续保存下一个表单实例数据。当noExecuteExpression为false时此参数才生效。</p>
     */
    @NameInMap("keepRunningAfterException")
    public Boolean keepRunningAfterException;

    /**
     * <p>是否不触发表单绑定的校验规则、关联业务规则和第三方服务回调（如果您的业务无必要执行这些，那么请填true以减小API的耗时以及获得更大的单次保存数据量上限）</p>
     */
    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    /**
     * <p>宜搭应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>钉钉userId</p>
     */
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
