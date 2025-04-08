// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportTrainingRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportTrainingRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportTrainingRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportTrainingRequest self = new HrbrainImportTrainingRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportTrainingRequest setBody(java.util.List<HrbrainImportTrainingRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportTrainingRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportTrainingRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportTrainingRequestBody extends TeaModel {
        @NameInMap("certifCnt")
        public String certifCnt;

        @NameInMap("creditScore")
        public String creditScore;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("deptNo")
        public String deptNo;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("jobCodeName")
        public String jobCodeName;

        @NameInMap("jobLevel")
        public String jobLevel;

        @NameInMap("name")
        public String name;

        @NameInMap("postName")
        public String postName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("trainEndDate")
        public String trainEndDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("trainName")
        public String trainName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("trainStartDate")
        public String trainStartDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportTrainingRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportTrainingRequestBody self = new HrbrainImportTrainingRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportTrainingRequestBody setCertifCnt(String certifCnt) {
            this.certifCnt = certifCnt;
            return this;
        }
        public String getCertifCnt() {
            return this.certifCnt;
        }

        public HrbrainImportTrainingRequestBody setCreditScore(String creditScore) {
            this.creditScore = creditScore;
            return this;
        }
        public String getCreditScore() {
            return this.creditScore;
        }

        public HrbrainImportTrainingRequestBody setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public HrbrainImportTrainingRequestBody setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public HrbrainImportTrainingRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportTrainingRequestBody setJobCodeName(String jobCodeName) {
            this.jobCodeName = jobCodeName;
            return this;
        }
        public String getJobCodeName() {
            return this.jobCodeName;
        }

        public HrbrainImportTrainingRequestBody setJobLevel(String jobLevel) {
            this.jobLevel = jobLevel;
            return this;
        }
        public String getJobLevel() {
            return this.jobLevel;
        }

        public HrbrainImportTrainingRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportTrainingRequestBody setPostName(String postName) {
            this.postName = postName;
            return this;
        }
        public String getPostName() {
            return this.postName;
        }

        public HrbrainImportTrainingRequestBody setTrainEndDate(String trainEndDate) {
            this.trainEndDate = trainEndDate;
            return this;
        }
        public String getTrainEndDate() {
            return this.trainEndDate;
        }

        public HrbrainImportTrainingRequestBody setTrainName(String trainName) {
            this.trainName = trainName;
            return this;
        }
        public String getTrainName() {
            return this.trainName;
        }

        public HrbrainImportTrainingRequestBody setTrainStartDate(String trainStartDate) {
            this.trainStartDate = trainStartDate;
            return this;
        }
        public String getTrainStartDate() {
            return this.trainStartDate;
        }

        public HrbrainImportTrainingRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
