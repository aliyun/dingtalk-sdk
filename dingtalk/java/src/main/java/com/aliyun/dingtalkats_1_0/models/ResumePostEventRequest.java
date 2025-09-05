// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ResumePostEventRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>王先生</p>
     */
    @NameInMap("candidateName")
    public String candidateName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>总裁助理</p>
     */
    @NameInMap("jobName")
    public String jobName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123123</p>
     */
    @NameInMap("jobOwnerUserId")
    public String jobOwnerUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
     */
    @NameInMap("mobileResumeUrl")
    public String mobileResumeUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="http://www.dingtalk.com">www.dingtalk.com</a></p>
     */
    @NameInMap("pcResumeUrl")
    public String pcResumeUrl;

    /**
     * <strong>example:</strong>
     * <p>3年 | 本科</p>
     */
    @NameInMap("resumeDesc")
    public String resumeDesc;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("resumePostTime")
    public Long resumePostTime;

    public static ResumePostEventRequest build(java.util.Map<String, ?> map) throws Exception {
        ResumePostEventRequest self = new ResumePostEventRequest();
        return TeaModel.build(map, self);
    }

    public ResumePostEventRequest setCandidateName(String candidateName) {
        this.candidateName = candidateName;
        return this;
    }
    public String getCandidateName() {
        return this.candidateName;
    }

    public ResumePostEventRequest setJobName(String jobName) {
        this.jobName = jobName;
        return this;
    }
    public String getJobName() {
        return this.jobName;
    }

    public ResumePostEventRequest setJobOwnerUserId(String jobOwnerUserId) {
        this.jobOwnerUserId = jobOwnerUserId;
        return this;
    }
    public String getJobOwnerUserId() {
        return this.jobOwnerUserId;
    }

    public ResumePostEventRequest setMobileResumeUrl(String mobileResumeUrl) {
        this.mobileResumeUrl = mobileResumeUrl;
        return this;
    }
    public String getMobileResumeUrl() {
        return this.mobileResumeUrl;
    }

    public ResumePostEventRequest setPcResumeUrl(String pcResumeUrl) {
        this.pcResumeUrl = pcResumeUrl;
        return this;
    }
    public String getPcResumeUrl() {
        return this.pcResumeUrl;
    }

    public ResumePostEventRequest setResumeDesc(String resumeDesc) {
        this.resumeDesc = resumeDesc;
        return this;
    }
    public String getResumeDesc() {
        return this.resumeDesc;
    }

    public ResumePostEventRequest setResumePostTime(Long resumePostTime) {
        this.resumePostTime = resumePostTime;
        return this;
    }
    public Long getResumePostTime() {
        return this.resumePostTime;
    }

}
