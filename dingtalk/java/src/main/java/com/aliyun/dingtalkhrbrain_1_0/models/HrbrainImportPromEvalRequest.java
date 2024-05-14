// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportPromEvalRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.List<HrbrainImportPromEvalRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static HrbrainImportPromEvalRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportPromEvalRequest self = new HrbrainImportPromEvalRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainImportPromEvalRequest setBody(java.util.List<HrbrainImportPromEvalRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<HrbrainImportPromEvalRequestBody> getBody() {
        return this.body;
    }

    public HrbrainImportPromEvalRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public static class HrbrainImportPromEvalRequestBody extends TeaModel {
        @NameInMap("comment")
        public String comment;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("effectiveDate")
        public String effectiveDate;

        @NameInMap("extendInfo")
        public java.util.Map<String, ?> extendInfo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("newJobLevel")
        public String newJobLevel;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("period")
        public String period;

        @NameInMap("periodEndDate")
        public String periodEndDate;

        @NameInMap("periodStartDate")
        public String periodStartDate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("preJobLevel")
        public String preJobLevel;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("workNo")
        public String workNo;

        public static HrbrainImportPromEvalRequestBody build(java.util.Map<String, ?> map) throws Exception {
            HrbrainImportPromEvalRequestBody self = new HrbrainImportPromEvalRequestBody();
            return TeaModel.build(map, self);
        }

        public HrbrainImportPromEvalRequestBody setComment(String comment) {
            this.comment = comment;
            return this;
        }
        public String getComment() {
            return this.comment;
        }

        public HrbrainImportPromEvalRequestBody setEffectiveDate(String effectiveDate) {
            this.effectiveDate = effectiveDate;
            return this;
        }
        public String getEffectiveDate() {
            return this.effectiveDate;
        }

        public HrbrainImportPromEvalRequestBody setExtendInfo(java.util.Map<String, ?> extendInfo) {
            this.extendInfo = extendInfo;
            return this;
        }
        public java.util.Map<String, ?> getExtendInfo() {
            return this.extendInfo;
        }

        public HrbrainImportPromEvalRequestBody setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public HrbrainImportPromEvalRequestBody setNewJobLevel(String newJobLevel) {
            this.newJobLevel = newJobLevel;
            return this;
        }
        public String getNewJobLevel() {
            return this.newJobLevel;
        }

        public HrbrainImportPromEvalRequestBody setPeriod(String period) {
            this.period = period;
            return this;
        }
        public String getPeriod() {
            return this.period;
        }

        public HrbrainImportPromEvalRequestBody setPeriodEndDate(String periodEndDate) {
            this.periodEndDate = periodEndDate;
            return this;
        }
        public String getPeriodEndDate() {
            return this.periodEndDate;
        }

        public HrbrainImportPromEvalRequestBody setPeriodStartDate(String periodStartDate) {
            this.periodStartDate = periodStartDate;
            return this;
        }
        public String getPeriodStartDate() {
            return this.periodStartDate;
        }

        public HrbrainImportPromEvalRequestBody setPreJobLevel(String preJobLevel) {
            this.preJobLevel = preJobLevel;
            return this;
        }
        public String getPreJobLevel() {
            return this.preJobLevel;
        }

        public HrbrainImportPromEvalRequestBody setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

}
