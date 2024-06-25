// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateFormDataByInstanceMapRequest extends TeaModel {
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
     * <p>{&quot;FINST-ANSFSNNDS2212NSKLKKSFD&quot;:&quot;{&quot;rateField_l0c1cwis&quot;:3,&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}]}&quot;}</p>
     */
    @NameInMap("updateFormDataJsonMap")
    public java.util.Map<String, ?> updateFormDataJsonMap;

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
