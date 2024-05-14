// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UploadLearningDataCallbackRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("generatedTime")
    public Long generatedTime;

    @NameInMap("studentUserId")
    public String studentUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subjectCode")
    public String subjectCode;

    public static UploadLearningDataCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadLearningDataCallbackRequest self = new UploadLearningDataCallbackRequest();
        return TeaModel.build(map, self);
    }

    public UploadLearningDataCallbackRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public UploadLearningDataCallbackRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public UploadLearningDataCallbackRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public UploadLearningDataCallbackRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public UploadLearningDataCallbackRequest setGeneratedTime(Long generatedTime) {
        this.generatedTime = generatedTime;
        return this;
    }
    public Long getGeneratedTime() {
        return this.generatedTime;
    }

    public UploadLearningDataCallbackRequest setStudentUserId(String studentUserId) {
        this.studentUserId = studentUserId;
        return this;
    }
    public String getStudentUserId() {
        return this.studentUserId;
    }

    public UploadLearningDataCallbackRequest setSubjectCode(String subjectCode) {
        this.subjectCode = subjectCode;
        return this;
    }
    public String getSubjectCode() {
        return this.subjectCode;
    }

}
