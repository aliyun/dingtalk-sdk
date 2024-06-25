// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchSaveFormDataRequest extends TeaModel {
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
     * <p>&quot;{&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}],&quot;addressField_l0c1cwiy&quot;:{&quot;address&quot;:&quot;111&quot;,&quot;regionIds&quot;:[460000,469027,469023401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;},{&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;},{&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;}]}}&quot;</p>
     */
    @NameInMap("formDataJsonList")
    public java.util.List<String> formDataJsonList;

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
    @NameInMap("keepRunningAfterException")
    public Boolean keepRunningAfterException;

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
     * <p>ding173982232112232</p>
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
