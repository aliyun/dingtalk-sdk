// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("asynchronousExecution")
    public Boolean asynchronousExecution;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</p>
     */
    @NameInMap("formInstanceIdList")
    public java.util.List<String> formInstanceIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("ignoreEmpty")
    public Boolean ignoreEmpty;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}],&quot;addressField_l0c1cwiy&quot;:{&quot;address&quot;:&quot;111&quot;,&quot;regionIds&quot;:[460000,469027,469023401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;},{&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;},{&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;}]}}</p>
     */
    @NameInMap("updateFormDataJson")
    public String updateFormDataJson;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("useLatestFormSchemaVersion")
    public Boolean useLatestFormSchemaVersion;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding173982232112232</p>
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
