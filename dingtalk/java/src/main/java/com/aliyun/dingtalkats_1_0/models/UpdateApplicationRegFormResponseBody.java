// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplicationRegFormResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("creatorUserId")
    public String creatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formId")
    public String formId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("gmtCreateMillis")
    public Long gmtCreateMillis;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("gmtModifiedMillis")
    public Long gmtModifiedMillis;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("templateVersion")
    public Integer templateVersion;

    public static UpdateApplicationRegFormResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateApplicationRegFormResponseBody self = new UpdateApplicationRegFormResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateApplicationRegFormResponseBody setCreatorUserId(String creatorUserId) {
        this.creatorUserId = creatorUserId;
        return this;
    }
    public String getCreatorUserId() {
        return this.creatorUserId;
    }

    public UpdateApplicationRegFormResponseBody setFormId(String formId) {
        this.formId = formId;
        return this;
    }
    public String getFormId() {
        return this.formId;
    }

    public UpdateApplicationRegFormResponseBody setGmtCreateMillis(Long gmtCreateMillis) {
        this.gmtCreateMillis = gmtCreateMillis;
        return this;
    }
    public Long getGmtCreateMillis() {
        return this.gmtCreateMillis;
    }

    public UpdateApplicationRegFormResponseBody setGmtModifiedMillis(Long gmtModifiedMillis) {
        this.gmtModifiedMillis = gmtModifiedMillis;
        return this;
    }
    public Long getGmtModifiedMillis() {
        return this.gmtModifiedMillis;
    }

    public UpdateApplicationRegFormResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public UpdateApplicationRegFormResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public UpdateApplicationRegFormResponseBody setTemplateVersion(Integer templateVersion) {
        this.templateVersion = templateVersion;
        return this;
    }
    public Integer getTemplateVersion() {
        return this.templateVersion;
    }

}
