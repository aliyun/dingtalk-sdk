// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetAsyncCreateContractAnalysisResponseBody extends TeaModel {
    @NameInMap("analysisStatus")
    public String analysisStatus;

    @NameInMap("companyList")
    public java.util.List<String> companyList;

    @NameInMap("reviewPositions")
    public java.util.List<String> reviewPositions;

    @NameInMap("reviewType")
    public String reviewType;

    @NameInMap("wordCount")
    public Integer wordCount;

    public static GetAsyncCreateContractAnalysisResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncCreateContractAnalysisResponseBody self = new GetAsyncCreateContractAnalysisResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAsyncCreateContractAnalysisResponseBody setAnalysisStatus(String analysisStatus) {
        this.analysisStatus = analysisStatus;
        return this;
    }
    public String getAnalysisStatus() {
        return this.analysisStatus;
    }

    public GetAsyncCreateContractAnalysisResponseBody setCompanyList(java.util.List<String> companyList) {
        this.companyList = companyList;
        return this;
    }
    public java.util.List<String> getCompanyList() {
        return this.companyList;
    }

    public GetAsyncCreateContractAnalysisResponseBody setReviewPositions(java.util.List<String> reviewPositions) {
        this.reviewPositions = reviewPositions;
        return this;
    }
    public java.util.List<String> getReviewPositions() {
        return this.reviewPositions;
    }

    public GetAsyncCreateContractAnalysisResponseBody setReviewType(String reviewType) {
        this.reviewType = reviewType;
        return this;
    }
    public String getReviewType() {
        return this.reviewType;
    }

    public GetAsyncCreateContractAnalysisResponseBody setWordCount(Integer wordCount) {
        this.wordCount = wordCount;
        return this;
    }
    public Integer getWordCount() {
        return this.wordCount;
    }

}
