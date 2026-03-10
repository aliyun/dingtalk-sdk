// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractSubjectRiskResultResponseBody extends TeaModel {
    @NameInMap("subjectRiskResponses")
    public java.util.List<GetContractSubjectRiskResultResponseBodySubjectRiskResponses> subjectRiskResponses;

    @NameInMap("success")
    public Boolean success;

    public static GetContractSubjectRiskResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetContractSubjectRiskResultResponseBody self = new GetContractSubjectRiskResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetContractSubjectRiskResultResponseBody setSubjectRiskResponses(java.util.List<GetContractSubjectRiskResultResponseBodySubjectRiskResponses> subjectRiskResponses) {
        this.subjectRiskResponses = subjectRiskResponses;
        return this;
    }
    public java.util.List<GetContractSubjectRiskResultResponseBodySubjectRiskResponses> getSubjectRiskResponses() {
        return this.subjectRiskResponses;
    }

    public GetContractSubjectRiskResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse extends TeaModel {
        @NameInMap("creditCode")
        public String creditCode;

        @NameInMap("establishTime")
        public Long establishTime;

        @NameInMap("legalPersonName")
        public String legalPersonName;

        @NameInMap("regLocation")
        public String regLocation;

        public static GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse build(java.util.Map<String, ?> map) throws Exception {
            GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse self = new GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse();
            return TeaModel.build(map, self);
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setCreditCode(String creditCode) {
            this.creditCode = creditCode;
            return this;
        }
        public String getCreditCode() {
            return this.creditCode;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setEstablishTime(Long establishTime) {
            this.establishTime = establishTime;
            return this;
        }
        public Long getEstablishTime() {
            return this.establishTime;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setLegalPersonName(String legalPersonName) {
            this.legalPersonName = legalPersonName;
            return this;
        }
        public String getLegalPersonName() {
            return this.legalPersonName;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegLocation(String regLocation) {
            this.regLocation = regLocation;
            return this;
        }
        public String getRegLocation() {
            return this.regLocation;
        }

    }

    public static class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse extends TeaModel {
        @NameInMap("isSubjectExist")
        public Boolean isSubjectExist;

        @NameInMap("riskTypes")
        public java.util.List<String> riskTypes;

        @NameInMap("risks")
        public java.util.Map<String, ?> risks;

        @NameInMap("totalRiskNumber")
        public Integer totalRiskNumber;

        public static GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse build(java.util.Map<String, ?> map) throws Exception {
            GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse self = new GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse();
            return TeaModel.build(map, self);
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse setIsSubjectExist(Boolean isSubjectExist) {
            this.isSubjectExist = isSubjectExist;
            return this;
        }
        public Boolean getIsSubjectExist() {
            return this.isSubjectExist;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse setRiskTypes(java.util.List<String> riskTypes) {
            this.riskTypes = riskTypes;
            return this;
        }
        public java.util.List<String> getRiskTypes() {
            return this.riskTypes;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse setRisks(java.util.Map<String, ?> risks) {
            this.risks = risks;
            return this;
        }
        public java.util.Map<String, ?> getRisks() {
            return this.risks;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse setTotalRiskNumber(Integer totalRiskNumber) {
            this.totalRiskNumber = totalRiskNumber;
            return this;
        }
        public Integer getTotalRiskNumber() {
            return this.totalRiskNumber;
        }

    }

    public static class GetContractSubjectRiskResultResponseBodySubjectRiskResponses extends TeaModel {
        @NameInMap("subjectBaseInfoResponse")
        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse subjectBaseInfoResponse;

        @NameInMap("subjectName")
        public String subjectName;

        @NameInMap("subjectRiskListResponse")
        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse subjectRiskListResponse;

        public static GetContractSubjectRiskResultResponseBodySubjectRiskResponses build(java.util.Map<String, ?> map) throws Exception {
            GetContractSubjectRiskResultResponseBodySubjectRiskResponses self = new GetContractSubjectRiskResultResponseBodySubjectRiskResponses();
            return TeaModel.build(map, self);
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponses setSubjectBaseInfoResponse(GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse subjectBaseInfoResponse) {
            this.subjectBaseInfoResponse = subjectBaseInfoResponse;
            return this;
        }
        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse getSubjectBaseInfoResponse() {
            return this.subjectBaseInfoResponse;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponses setSubjectName(String subjectName) {
            this.subjectName = subjectName;
            return this;
        }
        public String getSubjectName() {
            return this.subjectName;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponses setSubjectRiskListResponse(GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse subjectRiskListResponse) {
            this.subjectRiskListResponse = subjectRiskListResponse;
            return this;
        }
        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse getSubjectRiskListResponse() {
            return this.subjectRiskListResponse;
        }

    }

}
