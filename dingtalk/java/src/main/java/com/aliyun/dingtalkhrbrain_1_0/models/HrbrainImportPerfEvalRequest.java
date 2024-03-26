// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportPerfEvalRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<HrbrainImportPerfEvalRequestBody> body;

    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportPerfEvalRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportPerfEvalRequest self = new HrbrainImportPerfEvalRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportPerfEvalRequest setBody(java.util.List<HrbrainImportPerfEvalRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportPerfEvalRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportPerfEvalRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportPerfEvalRequestBody extends TeaModel {
        @NameInMap("comment")
        public String comment;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        @NameInMap("name")
        public String name;

        @NameInMap("perfCate")
        public String perfCate;

        @NameInMap("perfPlanName")
        public String perfPlanName;

        @NameInMap("perfScore")
        public String perfScore;

        @NameInMap("period")
        public String period;

        @NameInMap("periodEndDate")
        public String periodEndDate;

        @NameInMap("periodStartDate")
        public String periodStartDate;

        @NameInMap("score")
        public String score;

        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportPerfEvalRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportPerfEvalRequestBody self = new HrbrainImportPerfEvalRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportPerfEvalRequestBody setComment(String comment) {
            this.comment = comment;
            return this;
        }
        public String getComment() {
            return this.comment;
        }

        public HrbrainImportPerfEvalRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportPerfEvalRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportPerfEvalRequestBody setPerfCate(String perfCate) {
            this.perfCate = perfCate;
            return this;
        }
        public String getPerfCate() {
            return this.perfCate;
        }

        public HrbrainImportPerfEvalRequestBody setPerfPlanName(String perfPlanName) {
            this.perfPlanName = perfPlanName;
            return this;
        }
        public String getPerfPlanName() {
            return this.perfPlanName;
        }

        public HrbrainImportPerfEvalRequestBody setPerfScore(String perfScore) {
            this.perfScore = perfScore;
            return this;
        }
        public String getPerfScore() {
            return this.perfScore;
        }

        public HrbrainImportPerfEvalRequestBody setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public HrbrainImportPerfEvalRequestBody setPeriodEndDate(String periodEndDate) {
            this.periodEndDate = periodEndDate;
            return this;
        }
        public String getPeriodEndDate() {
            return this.periodEndDate;
        }

        public HrbrainImportPerfEvalRequestBody setPeriodStartDate(String periodStartDate) {
            this.periodStartDate = periodStartDate;
            return this;
        }
        public String getPeriodStartDate() {
            return this.periodStartDate;
        }

        public HrbrainImportPerfEvalRequestBody setScore(String score) {
            this.score = score;
            return this;
        }
        public String getScore() {
            return this.score;
        }

        public HrbrainImportPerfEvalRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
