// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class UpdateApplicationRegFormResponseBody extends TeaModel {
    /**
     * <p>邀填人员工标识</p>
     */
    @NameInMap("creatorUserId")
    public String creatorUserId;

    /**
     * <p>表单标识</p>
     */
    @NameInMap("formId")
    public String formId;

    /**
     * <p>创建时间（邀填时间，单位：毫秒）</p>
     */
    @NameInMap("gmtCreateMillis")
    public Long gmtCreateMillis;

    /**
     * <p>更新时间（填写时间，单位：毫秒），仅当表单状态为已填写时有效</p>
     */
    @NameInMap("gmtModifiedMillis")
    public Long gmtModifiedMillis;

    /**
     * <p>表单状态（0表示未填写，1表示已填写）</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>模板标识</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>模板版本</p>
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
