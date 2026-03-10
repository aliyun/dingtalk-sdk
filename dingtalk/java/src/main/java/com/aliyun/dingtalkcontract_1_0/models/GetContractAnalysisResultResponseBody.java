// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractAnalysisResultResponseBody extends TeaModel {
    @NameInMap("companyList")
    public java.util.List<String> companyList;

    @NameInMap("reviewPositions")
    public java.util.List<String> reviewPositions;

    @NameInMap("reviewType")
    public String reviewType;

    @NameInMap("wordCount")
    public Integer wordCount;

    public static GetContractAnalysisResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContractAnalysisResultResponseBody self = new GetContractAnalysisResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContractAnalysisResultResponseBody setCompanyList(java.util.List<String> companyList) {
        this.companyList = companyList;
        return this;
    }
    public java.util.List<String> getCompanyList() {
        return this.companyList;
    }

    public GetContractAnalysisResultResponseBody setReviewPositions(java.util.List<String> reviewPositions) {
        this.reviewPositions = reviewPositions;
        return this;
    }
    public java.util.List<String> getReviewPositions() {
        return this.reviewPositions;
    }

    public GetContractAnalysisResultResponseBody setReviewType(String reviewType) {
        this.reviewType = reviewType;
        return this;
    }
    public String getReviewType() {
        return this.reviewType;
    }

    public GetContractAnalysisResultResponseBody setWordCount(Integer wordCount) {
        this.wordCount = wordCount;
        return this;
    }
    public Integer getWordCount() {
        return this.wordCount;
    }

}
