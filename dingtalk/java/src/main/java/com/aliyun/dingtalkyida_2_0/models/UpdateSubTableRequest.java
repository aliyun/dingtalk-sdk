// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateSubTableRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

    @NameInMap("language")
    public String language;

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
     */
    @NameInMap("tableFieldIds")
    public String tableFieldIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}],&quot;addressField_l0c1cwiy&quot;:{&quot;address&quot;:&quot;111&quot;,&quot;regionIds&quot;:[460000,469027,469023401],&quot;regionText&quot;:[{&quot;en_US&quot;:&quot;hai+nan+sheng&quot;,&quot;zh_CN&quot;:&quot;海南省&quot;},{&quot;en_US&quot;:&quot;cheng+mai+xian&quot;,&quot;zh_CN&quot;:&quot;澄迈县&quot;},{&quot;en_US&quot;:&quot;guo+ying+hong+gang+nong+chang&quot;,&quot;zh_CN&quot;:&quot;国营红岗农场&quot;}]}}</p>
     */
    @NameInMap("updateFormDataJson")
    public String updateFormDataJson;

    @NameInMap("useAlias")
    public Boolean useAlias;

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

    public static UpdateSubTableRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubTableRequest self = new UpdateSubTableRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSubTableRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public UpdateSubTableRequest setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public UpdateSubTableRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateSubTableRequest setNoExecuteExpression(Boolean noExecuteExpression) {
        this.noExecuteExpression = noExecuteExpression;
        return this;
    }
    public Boolean getNoExecuteExpression() {
        return this.noExecuteExpression;
    }

    public UpdateSubTableRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public UpdateSubTableRequest setTableFieldIds(String tableFieldIds) {
        this.tableFieldIds = tableFieldIds;
        return this;
    }
    public String getTableFieldIds() {
        return this.tableFieldIds;
    }

    public UpdateSubTableRequest setUpdateFormDataJson(String updateFormDataJson) {
        this.updateFormDataJson = updateFormDataJson;
        return this;
    }
    public String getUpdateFormDataJson() {
        return this.updateFormDataJson;
    }

    public UpdateSubTableRequest setUseAlias(Boolean useAlias) {
        this.useAlias = useAlias;
        return this;
    }
    public Boolean getUseAlias() {
        return this.useAlias;
    }

    public UpdateSubTableRequest setUseLatestFormSchemaVersion(Boolean useLatestFormSchemaVersion) {
        this.useLatestFormSchemaVersion = useLatestFormSchemaVersion;
        return this;
    }
    public Boolean getUseLatestFormSchemaVersion() {
        return this.useLatestFormSchemaVersion;
    }

    public UpdateSubTableRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
