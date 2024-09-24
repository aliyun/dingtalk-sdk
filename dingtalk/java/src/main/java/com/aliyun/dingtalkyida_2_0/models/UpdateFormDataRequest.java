// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class UpdateFormDataRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>33f6d221-17f8-42b7-836a-682b95a046c2</p>
     */
    @NameInMap("formInstanceId")
    public String formInstanceId;

    /**
     * <strong>example:</strong>
     * <p>FORM-AA28579F69644FC19A47FE267457E664ZVR1</p>
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
     * <p>{&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;textareaField_jcr0069n&quot;:&quot;duohang&quot;,&quot;numberField_jcr0069o&quot;:1,&quot;radioField_jcr0069p&quot;:&quot;选项一&quot;,&quot;selectField_jcr0069q&quot;:&quot;选项一&quot;,&quot;checkboxField_jcr0069r&quot;:[&quot;选项二&quot;,&quot;选项三&quot;],&quot;multiSelectField_jcr0069s&quot;:[&quot;选项二&quot;,&quot;选项三&quot;],&quot;dateField_jcr0069t&quot;:1516636800000,&quot;cascadeDate_jcr0069u&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;employeeField_jcr0069x&quot;:[&quot;xxxxx&quot;],&quot;citySelectField_jcr0069y&quot;:[&quot;110000&quot;,&quot;110100&quot;,&quot;110101&quot;],&quot;departmentField_jcr0069z&quot;:1123456,&quot;cascadeSelectField_jcr006a0&quot;:[&quot;part&quot;,&quot;part_b&quot;],{&quot;attachmentField_jna1lvyb&quot;:[{&quot;downloadUrl&quot;:&quot;<a href="https://www.aliwork.com/fileHandle?appType=default_tianshu_app&fileName=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt&instId=&type=download%22,%22name%22:%22test.txt%22,%22previewUrl%22:%22https://www.aliwork.com/inst/preview?appType=default_tianshu_app&fileName=test.txt&fileSize=4&downloadUrl=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt%22,%22url%22:%22https://www.aliwork.com/fileHandle?appType=default_tianshu_app&fileName=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt&instId=&type=download%22,%22ext%22:%22txt%22%7D%5D%7D,%22tableField_jcr006a1%22:%5B%7B%22cascadeDate_jcr006aa%22:%5B%221514736000000%22,%221517328000000%22%5D,%22cascadeSelectField_jcr006ae%22:%5B%22product%22,%22product_a%22%5D,%22checkboxField_jcr006a7%22:%5B%22%E9%80%89%E9%A1%B9%E4%B8%80%22,%22%E9%80%89%E9%A1%B9%E4%BA%8C%22,%22%E9%80%89%E9%A1%B9%E4%B8%89%22%5D,%22citySelectField_jcr006ac%22:%5B%22120000%22,%22120100%22,%22120102%22%5D,%22dateField_jcr006a9%22:1517328000000,%22departmentField_jcr006ad%22:1123456,%22employeeField_jcr006ab%22:%5B%22yyyyy%22,%22xxxxx%22%5D,%22multiSelectField_jcr006a8%22:%5B%22%E9%80%89%E9%A1%B9%E4%B8%80%22,%22%E9%80%89%E9%A1%B9%E4%BA%8C%22,%22%E9%80%89%E9%A1%B9%E4%B8%89%22%5D,%22numberField_jcr006a4%22:2,%22radioField_jcr006a5%22:%22%E9%80%89%E9%A1%B9%E4%BA%8C%22,%22selectField_jcr006a6%22:%22%E9%80%89%E9%A1%B9%E4%B8%89%22,%22textField_jcr006a2%22:%22%E6%98%8E%E7%BB%86%E4%B8%8B%E5%8D%95%E8%A1%8C%22,%22textareaField_jcr006a3%22:%22%E6%98%8E%E7%BB%86%E4%B8%8B%E5%A4%9A%E8%A1%8C%22%7D%5D%7D">https://www.aliwork.com/fileHandle?appType=default_tianshu_app&amp;fileName=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt&amp;instId=&amp;type=download&quot;,&quot;name&quot;:&quot;test.txt&quot;,&quot;previewUrl&quot;:&quot;https://www.aliwork.com/inst/preview?appType=default_tianshu_app&amp;fileName=test.txt&amp;fileSize=4&amp;downloadUrl=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt&quot;,&quot;url&quot;:&quot;https://www.aliwork.com/fileHandle?appType=default_tianshu_app&amp;fileName=edd07ca9-1d2e-44b5-98fe-c1e16202f90d.txt&amp;instId=&amp;type=download&quot;,&quot;ext&quot;:&quot;txt&quot;}]},&quot;tableField_jcr006a1&quot;:[{&quot;cascadeDate_jcr006aa&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;cascadeSelectField_jcr006ae&quot;:[&quot;product&quot;,&quot;product_a&quot;],&quot;checkboxField_jcr006a7&quot;:[&quot;选项一&quot;,&quot;选项二&quot;,&quot;选项三&quot;],&quot;citySelectField_jcr006ac&quot;:[&quot;120000&quot;,&quot;120100&quot;,&quot;120102&quot;],&quot;dateField_jcr006a9&quot;:1517328000000,&quot;departmentField_jcr006ad&quot;:1123456,&quot;employeeField_jcr006ab&quot;:[&quot;yyyyy&quot;,&quot;xxxxx&quot;],&quot;multiSelectField_jcr006a8&quot;:[&quot;选项一&quot;,&quot;选项二&quot;,&quot;选项三&quot;],&quot;numberField_jcr006a4&quot;:2,&quot;radioField_jcr006a5&quot;:&quot;选项二&quot;,&quot;selectField_jcr006a6&quot;:&quot;选项三&quot;,&quot;textField_jcr006a2&quot;:&quot;明细下单行&quot;,&quot;textareaField_jcr006a3&quot;:&quot;明细下多行&quot;}]}</a></p>
     */
    @NameInMap("updateFormDataJson")
    public String updateFormDataJson;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("useAlias")
    public Boolean useAlias;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("useLatestVersion")
    public Boolean useLatestVersion;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateFormDataRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFormDataRequest self = new UpdateFormDataRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFormDataRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public UpdateFormDataRequest setFormInstanceId(String formInstanceId) {
        this.formInstanceId = formInstanceId;
        return this;
    }
    public String getFormInstanceId() {
        return this.formInstanceId;
    }

    public UpdateFormDataRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public UpdateFormDataRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public UpdateFormDataRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public UpdateFormDataRequest setUpdateFormDataJson(String updateFormDataJson) {
        this.updateFormDataJson = updateFormDataJson;
        return this;
    }
    public String getUpdateFormDataJson() {
        return this.updateFormDataJson;
    }

    public UpdateFormDataRequest setUseAlias(Boolean useAlias) {
        this.useAlias = useAlias;
        return this;
    }
    public Boolean getUseAlias() {
        return this.useAlias;
    }

    public UpdateFormDataRequest setUseLatestVersion(Boolean useLatestVersion) {
        this.useLatestVersion = useLatestVersion;
        return this;
    }
    public Boolean getUseLatestVersion() {
        return this.useLatestVersion;
    }

    public UpdateFormDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
