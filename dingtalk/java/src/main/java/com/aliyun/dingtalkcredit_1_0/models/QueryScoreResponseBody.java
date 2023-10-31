// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcredit_1_0.models;

import com.aliyun.tea.*;

public class QueryScoreResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryScoreResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryScoreResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryScoreResponseBody self = new QueryScoreResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryScoreResponseBody setResult(QueryScoreResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryScoreResponseBodyResult getResult() {
        return this.result;
    }

    public QueryScoreResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryScoreResponseBodyResult extends TeaModel {
        @NameInMap("ccocScore")
        public Double ccocScore;

        @NameInMap("cityChangeCnt3y")
        public Long cityChangeCnt3y;

        @NameInMap("cityChangeTrend2y")
        public Double cityChangeTrend2y;

        @NameInMap("classificationOfOrg")
        public String classificationOfOrg;

        @NameInMap("growthRateLoginDays180d")
        public Double growthRateLoginDays180d;

        @NameInMap("indChangeCnt3y")
        public Long indChangeCnt3y;

        @NameInMap("indChangeTrend2y")
        public Double indChangeTrend2y;

        @NameInMap("jobChangeCnt3y")
        public Long jobChangeCnt3y;

        @NameInMap("jobTitle")
        public String jobTitle;

        @NameInMap("joinDays")
        public Long joinDays;

        @NameInMap("loginDays14dPct")
        public Double loginDays14dPct;

        @NameInMap("loginDays365dPct")
        public Double loginDays365dPct;

        @NameInMap("orgCnt")
        public Long orgCnt;

        @NameInMap("orgIndustrySubNameNew")
        public String orgIndustrySubNameNew;

        @NameInMap("orgIndustryUpNameNew")
        public String orgIndustryUpNameNew;

        public static QueryScoreResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryScoreResponseBodyResult self = new QueryScoreResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryScoreResponseBodyResult setCcocScore(Double ccocScore) {
            this.ccocScore = ccocScore;
            return this;
        }
        public Double getCcocScore() {
            return this.ccocScore;
        }

        public QueryScoreResponseBodyResult setCityChangeCnt3y(Long cityChangeCnt3y) {
            this.cityChangeCnt3y = cityChangeCnt3y;
            return this;
        }
        public Long getCityChangeCnt3y() {
            return this.cityChangeCnt3y;
        }

        public QueryScoreResponseBodyResult setCityChangeTrend2y(Double cityChangeTrend2y) {
            this.cityChangeTrend2y = cityChangeTrend2y;
            return this;
        }
        public Double getCityChangeTrend2y() {
            return this.cityChangeTrend2y;
        }

        public QueryScoreResponseBodyResult setClassificationOfOrg(String classificationOfOrg) {
            this.classificationOfOrg = classificationOfOrg;
            return this;
        }
        public String getClassificationOfOrg() {
            return this.classificationOfOrg;
        }

        public QueryScoreResponseBodyResult setGrowthRateLoginDays180d(Double growthRateLoginDays180d) {
            this.growthRateLoginDays180d = growthRateLoginDays180d;
            return this;
        }
        public Double getGrowthRateLoginDays180d() {
            return this.growthRateLoginDays180d;
        }

        public QueryScoreResponseBodyResult setIndChangeCnt3y(Long indChangeCnt3y) {
            this.indChangeCnt3y = indChangeCnt3y;
            return this;
        }
        public Long getIndChangeCnt3y() {
            return this.indChangeCnt3y;
        }

        public QueryScoreResponseBodyResult setIndChangeTrend2y(Double indChangeTrend2y) {
            this.indChangeTrend2y = indChangeTrend2y;
            return this;
        }
        public Double getIndChangeTrend2y() {
            return this.indChangeTrend2y;
        }

        public QueryScoreResponseBodyResult setJobChangeCnt3y(Long jobChangeCnt3y) {
            this.jobChangeCnt3y = jobChangeCnt3y;
            return this;
        }
        public Long getJobChangeCnt3y() {
            return this.jobChangeCnt3y;
        }

        public QueryScoreResponseBodyResult setJobTitle(String jobTitle) {
            this.jobTitle = jobTitle;
            return this;
        }
        public String getJobTitle() {
            return this.jobTitle;
        }

        public QueryScoreResponseBodyResult setJoinDays(Long joinDays) {
            this.joinDays = joinDays;
            return this;
        }
        public Long getJoinDays() {
            return this.joinDays;
        }

        public QueryScoreResponseBodyResult setLoginDays14dPct(Double loginDays14dPct) {
            this.loginDays14dPct = loginDays14dPct;
            return this;
        }
        public Double getLoginDays14dPct() {
            return this.loginDays14dPct;
        }

        public QueryScoreResponseBodyResult setLoginDays365dPct(Double loginDays365dPct) {
            this.loginDays365dPct = loginDays365dPct;
            return this;
        }
        public Double getLoginDays365dPct() {
            return this.loginDays365dPct;
        }

        public QueryScoreResponseBodyResult setOrgCnt(Long orgCnt) {
            this.orgCnt = orgCnt;
            return this;
        }
        public Long getOrgCnt() {
            return this.orgCnt;
        }

        public QueryScoreResponseBodyResult setOrgIndustrySubNameNew(String orgIndustrySubNameNew) {
            this.orgIndustrySubNameNew = orgIndustrySubNameNew;
            return this;
        }
        public String getOrgIndustrySubNameNew() {
            return this.orgIndustrySubNameNew;
        }

        public QueryScoreResponseBodyResult setOrgIndustryUpNameNew(String orgIndustryUpNameNew) {
            this.orgIndustryUpNameNew = orgIndustryUpNameNew;
            return this;
        }
        public String getOrgIndustryUpNameNew() {
            return this.orgIndustryUpNameNew;
        }

    }

}
