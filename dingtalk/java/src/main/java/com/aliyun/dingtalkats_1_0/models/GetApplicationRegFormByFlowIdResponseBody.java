// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetApplicationRegFormByFlowIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("candidateId")
    public String candidateId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("creatorUserId")
    public String creatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("flowId")
    public String flowId;

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
    @NameInMap("jobId")
    public String jobId;

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

    public static GetApplicationRegFormByFlowIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetApplicationRegFormByFlowIdResponseBody self = new GetApplicationRegFormByFlowIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetApplicationRegFormByFlowIdResponseBody setCandidateId(String candidateId) {
        this.candidateId = candidateId;
        return this;
    }
    public String getCandidateId() {
        return this.candidateId;
    }

    public GetApplicationRegFormByFlowIdResponseBody setCreatorUserId(String creatorUserId) {
        this.creatorUserId = creatorUserId;
        return this;
    }
    public String getCreatorUserId() {
        return this.creatorUserId;
    }

    public GetApplicationRegFormByFlowIdResponseBody setFlowId(String flowId) {
        this.flowId = flowId;
        return this;
    }
    public String getFlowId() {
        return this.flowId;
    }

    public GetApplicationRegFormByFlowIdResponseBody setFormId(String formId) {
        this.formId = formId;
        return this;
    }
    public String getFormId() {
        return this.formId;
    }

    public GetApplicationRegFormByFlowIdResponseBody setGmtCreateMillis(Long gmtCreateMillis) {
        this.gmtCreateMillis = gmtCreateMillis;
        return this;
    }
    public Long getGmtCreateMillis() {
        return this.gmtCreateMillis;
    }

    public GetApplicationRegFormByFlowIdResponseBody setGmtModifiedMillis(Long gmtModifiedMillis) {
        this.gmtModifiedMillis = gmtModifiedMillis;
        return this;
    }
    public Long getGmtModifiedMillis() {
        return this.gmtModifiedMillis;
    }

    public GetApplicationRegFormByFlowIdResponseBody setJobId(String jobId) {
        this.jobId = jobId;
        return this;
    }
    public String getJobId() {
        return this.jobId;
    }

    public GetApplicationRegFormByFlowIdResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetApplicationRegFormByFlowIdResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public GetApplicationRegFormByFlowIdResponseBody setTemplateVersion(Integer templateVersion) {
        this.templateVersion = templateVersion;
        return this;
    }
    public Integer getTemplateVersion() {
        return this.templateVersion;
    }

}
