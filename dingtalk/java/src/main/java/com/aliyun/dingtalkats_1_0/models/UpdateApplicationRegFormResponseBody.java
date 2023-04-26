// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplicationRegFormResponseBody extends TeaModel {
    @NameInMap("creatorUserId")
    public String creatorUserId;

    @NameInMap("formId")
    public String formId;

    @NameInMap("gmtCreateMillis")
    public Long gmtCreateMillis;

    @NameInMap("gmtModifiedMillis")
    public Long gmtModifiedMillis;

    @NameInMap("status")
    public Integer status;

    @NameInMap("templateId")
    public String templateId;

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
