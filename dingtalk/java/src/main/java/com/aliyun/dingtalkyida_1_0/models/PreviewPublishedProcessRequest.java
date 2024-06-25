// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PreviewPublishedProcessRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>18295</p>
     */
    @NameInMap("departmentId")
    public String departmentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;textField_jcpm6agt&quot;: &quot;单行&quot;,&quot;employeeField_jcos0sar&quot;: [&quot;workno&quot;]}</p>
     */
    @NameInMap("formDataJson")
    public String formDataJson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-NJYJZELV8YZRDEI2N5IQ7L6VEDMR1VE9GMPCJB</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxx</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1731234567</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PreviewPublishedProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        PreviewPublishedProcessRequest self = new PreviewPublishedProcessRequest();
        return TeaModel.build(map, self);
    }

    public PreviewPublishedProcessRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public PreviewPublishedProcessRequest setDepartmentId(String departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public String getDepartmentId() {
        return this.departmentId;
    }

    public PreviewPublishedProcessRequest setFormDataJson(String formDataJson) {
        this.formDataJson = formDataJson;
        return this;
    }
    public String getFormDataJson() {
        return this.formDataJson;
    }

    public PreviewPublishedProcessRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public PreviewPublishedProcessRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public PreviewPublishedProcessRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PreviewPublishedProcessRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public PreviewPublishedProcessRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
