// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UploadLearningDataCallbackRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("bizType")
    public String bizType;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("generatedTime")
    public Long generatedTime;

    @NameInMap("studentUserId")
    public String studentUserId;

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
