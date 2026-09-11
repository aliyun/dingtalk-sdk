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

    public static class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll extends TeaModel {
        @NameInMap("category")
        public String category;

        @NameInMap("categoryBig")
        public String categoryBig;

        @NameInMap("categoryCodeFirst")
        public String categoryCodeFirst;

        @NameInMap("categoryCodeFourth")
        public String categoryCodeFourth;

        @NameInMap("categoryCodeSecond")
        public String categoryCodeSecond;

        @NameInMap("categoryCodeThird")
        public String categoryCodeThird;

        @NameInMap("categoryMiddle")
        public String categoryMiddle;

        @NameInMap("categorySmall")
        public String categorySmall;

        public static GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll build(java.util.Map<String, ?> map) throws Exception {
            GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll self = new GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll();
            return TeaModel.build(map, self);
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategoryBig(String categoryBig) {
            this.categoryBig = categoryBig;
            return this;
        }
        public String getCategoryBig() {
            return this.categoryBig;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategoryCodeFirst(String categoryCodeFirst) {
            this.categoryCodeFirst = categoryCodeFirst;
            return this;
        }
        public String getCategoryCodeFirst() {
            return this.categoryCodeFirst;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategoryCodeFourth(String categoryCodeFourth) {
            this.categoryCodeFourth = categoryCodeFourth;
            return this;
        }
        public String getCategoryCodeFourth() {
            return this.categoryCodeFourth;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategoryCodeSecond(String categoryCodeSecond) {
            this.categoryCodeSecond = categoryCodeSecond;
            return this;
        }
        public String getCategoryCodeSecond() {
            return this.categoryCodeSecond;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategoryCodeThird(String categoryCodeThird) {
            this.categoryCodeThird = categoryCodeThird;
            return this;
        }
        public String getCategoryCodeThird() {
            return this.categoryCodeThird;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategoryMiddle(String categoryMiddle) {
            this.categoryMiddle = categoryMiddle;
            return this;
        }
        public String getCategoryMiddle() {
            return this.categoryMiddle;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll setCategorySmall(String categorySmall) {
            this.categorySmall = categorySmall;
            return this;
        }
        public String getCategorySmall() {
            return this.categorySmall;
        }

    }

    public static class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse extends TeaModel {
        @NameInMap("aboveScale")
        public String aboveScale;

        @NameInMap("actualCapital")
        public String actualCapital;

        @NameInMap("actualCapitalCurrency")
        public String actualCapitalCurrency;

        @NameInMap("alias")
        public String alias;

        @NameInMap("approvedTime")
        public Long approvedTime;

        @NameInMap("base")
        public String base;

        @NameInMap("benNumber")
        public String benNumber;

        @NameInMap("bondName")
        public String bondName;

        @NameInMap("bondNum")
        public String bondNum;

        @NameInMap("bondType")
        public String bondType;

        @NameInMap("businessScope")
        public String businessScope;

        @NameInMap("cancelDate")
        public Long cancelDate;

        @NameInMap("cancelReason")
        public String cancelReason;

        @NameInMap("city")
        public String city;

        @NameInMap("companyOrgType")
        public String companyOrgType;

        @NameInMap("creditCode")
        public String creditCode;

        @NameInMap("district")
        public String district;

        @NameInMap("districtCode")
        public String districtCode;

        @NameInMap("economicFunctionZone1")
        public String economicFunctionZone1;

        @NameInMap("economicFunctionZone2")
        public String economicFunctionZone2;

        @NameInMap("email")
        public String email;

        @NameInMap("emailList")
        public String emailList;

        @NameInMap("establishTime")
        public Long establishTime;

        @NameInMap("fromTime")
        public Long fromTime;

        @NameInMap("historyNameList")
        public java.util.List<String> historyNameList;

        @NameInMap("historyNames")
        public String historyNames;

        @NameInMap("id")
        public Long id;

        @NameInMap("industry")
        public String industry;

        @NameInMap("industryAll")
        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll industryAll;

        @NameInMap("isMicroEnt")
        public Integer isMicroEnt;

        @NameInMap("legalPersonName")
        public String legalPersonName;

        @NameInMap("name")
        public String name;

        @NameInMap("numberSource")
        public String numberSource;

        @NameInMap("numberType")
        public String numberType;

        @NameInMap("orgNumber")
        public String orgNumber;

        @NameInMap("percentileScore")
        public Integer percentileScore;

        @NameInMap("phoneNumber")
        public String phoneNumber;

        @NameInMap("property3")
        public String property3;

        @NameInMap("regCapital")
        public String regCapital;

        @NameInMap("regCapitalCurrency")
        public String regCapitalCurrency;

        @NameInMap("regInstitute")
        public String regInstitute;

        @NameInMap("regLocation")
        public String regLocation;

        @NameInMap("regLocationHalfWidth")
        public String regLocationHalfWidth;

        @NameInMap("regNumber")
        public String regNumber;

        @NameInMap("regStatus")
        public String regStatus;

        @NameInMap("revokeDate")
        public Long revokeDate;

        @NameInMap("revokeReason")
        public String revokeReason;

        @NameInMap("socialStaffNum")
        public Long socialStaffNum;

        @NameInMap("staffNumRange")
        public String staffNumRange;

        @NameInMap("tags")
        public String tags;

        @NameInMap("taxNumber")
        public String taxNumber;

        @NameInMap("toTime")
        public Long toTime;

        @NameInMap("type")
        public Integer type;

        @NameInMap("updateTimes")
        public Long updateTimes;

        @NameInMap("usedBondName")
        public String usedBondName;

        @NameInMap("websiteList")
        public String websiteList;

        public static GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse build(java.util.Map<String, ?> map) throws Exception {
            GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse self = new GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse();
            return TeaModel.build(map, self);
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setAboveScale(String aboveScale) {
            this.aboveScale = aboveScale;
            return this;
        }
        public String getAboveScale() {
            return this.aboveScale;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setActualCapital(String actualCapital) {
            this.actualCapital = actualCapital;
            return this;
        }
        public String getActualCapital() {
            return this.actualCapital;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setActualCapitalCurrency(String actualCapitalCurrency) {
            this.actualCapitalCurrency = actualCapitalCurrency;
            return this;
        }
        public String getActualCapitalCurrency() {
            return this.actualCapitalCurrency;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setAlias(String alias) {
            this.alias = alias;
            return this;
        }
        public String getAlias() {
            return this.alias;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setApprovedTime(Long approvedTime) {
            this.approvedTime = approvedTime;
            return this;
        }
        public Long getApprovedTime() {
            return this.approvedTime;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setBase(String base) {
            this.base = base;
            return this;
        }
        public String getBase() {
            return this.base;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setBenNumber(String benNumber) {
            this.benNumber = benNumber;
            return this;
        }
        public String getBenNumber() {
            return this.benNumber;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setBondName(String bondName) {
            this.bondName = bondName;
            return this;
        }
        public String getBondName() {
            return this.bondName;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setBondNum(String bondNum) {
            this.bondNum = bondNum;
            return this;
        }
        public String getBondNum() {
            return this.bondNum;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setBondType(String bondType) {
            this.bondType = bondType;
            return this;
        }
        public String getBondType() {
            return this.bondType;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setBusinessScope(String businessScope) {
            this.businessScope = businessScope;
            return this;
        }
        public String getBusinessScope() {
            return this.businessScope;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setCancelDate(Long cancelDate) {
            this.cancelDate = cancelDate;
            return this;
        }
        public Long getCancelDate() {
            return this.cancelDate;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setCancelReason(String cancelReason) {
            this.cancelReason = cancelReason;
            return this;
        }
        public String getCancelReason() {
            return this.cancelReason;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setCity(String city) {
            this.city = city;
            return this;
        }
        public String getCity() {
            return this.city;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setCompanyOrgType(String companyOrgType) {
            this.companyOrgType = companyOrgType;
            return this;
        }
        public String getCompanyOrgType() {
            return this.companyOrgType;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setCreditCode(String creditCode) {
            this.creditCode = creditCode;
            return this;
        }
        public String getCreditCode() {
            return this.creditCode;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setDistrict(String district) {
            this.district = district;
            return this;
        }
        public String getDistrict() {
            return this.district;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setDistrictCode(String districtCode) {
            this.districtCode = districtCode;
            return this;
        }
        public String getDistrictCode() {
            return this.districtCode;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setEconomicFunctionZone1(String economicFunctionZone1) {
            this.economicFunctionZone1 = economicFunctionZone1;
            return this;
        }
        public String getEconomicFunctionZone1() {
            return this.economicFunctionZone1;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setEconomicFunctionZone2(String economicFunctionZone2) {
            this.economicFunctionZone2 = economicFunctionZone2;
            return this;
        }
        public String getEconomicFunctionZone2() {
            return this.economicFunctionZone2;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setEmailList(String emailList) {
            this.emailList = emailList;
            return this;
        }
        public String getEmailList() {
            return this.emailList;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setEstablishTime(Long establishTime) {
            this.establishTime = establishTime;
            return this;
        }
        public Long getEstablishTime() {
            return this.establishTime;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setFromTime(Long fromTime) {
            this.fromTime = fromTime;
            return this;
        }
        public Long getFromTime() {
            return this.fromTime;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setHistoryNameList(java.util.List<String> historyNameList) {
            this.historyNameList = historyNameList;
            return this;
        }
        public java.util.List<String> getHistoryNameList() {
            return this.historyNameList;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setHistoryNames(String historyNames) {
            this.historyNames = historyNames;
            return this;
        }
        public String getHistoryNames() {
            return this.historyNames;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setIndustry(String industry) {
            this.industry = industry;
            return this;
        }
        public String getIndustry() {
            return this.industry;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setIndustryAll(GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll industryAll) {
            this.industryAll = industryAll;
            return this;
        }
        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponseIndustryAll getIndustryAll() {
            return this.industryAll;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setIsMicroEnt(Integer isMicroEnt) {
            this.isMicroEnt = isMicroEnt;
            return this;
        }
        public Integer getIsMicroEnt() {
            return this.isMicroEnt;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setLegalPersonName(String legalPersonName) {
            this.legalPersonName = legalPersonName;
            return this;
        }
        public String getLegalPersonName() {
            return this.legalPersonName;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setNumberSource(String numberSource) {
            this.numberSource = numberSource;
            return this;
        }
        public String getNumberSource() {
            return this.numberSource;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setNumberType(String numberType) {
            this.numberType = numberType;
            return this;
        }
        public String getNumberType() {
            return this.numberType;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setOrgNumber(String orgNumber) {
            this.orgNumber = orgNumber;
            return this;
        }
        public String getOrgNumber() {
            return this.orgNumber;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setPercentileScore(Integer percentileScore) {
            this.percentileScore = percentileScore;
            return this;
        }
        public Integer getPercentileScore() {
            return this.percentileScore;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setPhoneNumber(String phoneNumber) {
            this.phoneNumber = phoneNumber;
            return this;
        }
        public String getPhoneNumber() {
            return this.phoneNumber;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setProperty3(String property3) {
            this.property3 = property3;
            return this;
        }
        public String getProperty3() {
            return this.property3;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegCapital(String regCapital) {
            this.regCapital = regCapital;
            return this;
        }
        public String getRegCapital() {
            return this.regCapital;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegCapitalCurrency(String regCapitalCurrency) {
            this.regCapitalCurrency = regCapitalCurrency;
            return this;
        }
        public String getRegCapitalCurrency() {
            return this.regCapitalCurrency;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegInstitute(String regInstitute) {
            this.regInstitute = regInstitute;
            return this;
        }
        public String getRegInstitute() {
            return this.regInstitute;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegLocation(String regLocation) {
            this.regLocation = regLocation;
            return this;
        }
        public String getRegLocation() {
            return this.regLocation;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegLocationHalfWidth(String regLocationHalfWidth) {
            this.regLocationHalfWidth = regLocationHalfWidth;
            return this;
        }
        public String getRegLocationHalfWidth() {
            return this.regLocationHalfWidth;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegNumber(String regNumber) {
            this.regNumber = regNumber;
            return this;
        }
        public String getRegNumber() {
            return this.regNumber;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRegStatus(String regStatus) {
            this.regStatus = regStatus;
            return this;
        }
        public String getRegStatus() {
            return this.regStatus;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRevokeDate(Long revokeDate) {
            this.revokeDate = revokeDate;
            return this;
        }
        public Long getRevokeDate() {
            return this.revokeDate;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setRevokeReason(String revokeReason) {
            this.revokeReason = revokeReason;
            return this;
        }
        public String getRevokeReason() {
            return this.revokeReason;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setSocialStaffNum(Long socialStaffNum) {
            this.socialStaffNum = socialStaffNum;
            return this;
        }
        public Long getSocialStaffNum() {
            return this.socialStaffNum;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setStaffNumRange(String staffNumRange) {
            this.staffNumRange = staffNumRange;
            return this;
        }
        public String getStaffNumRange() {
            return this.staffNumRange;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setTags(String tags) {
            this.tags = tags;
            return this;
        }
        public String getTags() {
            return this.tags;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setTaxNumber(String taxNumber) {
            this.taxNumber = taxNumber;
            return this;
        }
        public String getTaxNumber() {
            return this.taxNumber;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setToTime(Long toTime) {
            this.toTime = toTime;
            return this;
        }
        public Long getToTime() {
            return this.toTime;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setUpdateTimes(Long updateTimes) {
            this.updateTimes = updateTimes;
            return this;
        }
        public Long getUpdateTimes() {
            return this.updateTimes;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setUsedBondName(String usedBondName) {
            this.usedBondName = usedBondName;
            return this;
        }
        public String getUsedBondName() {
            return this.usedBondName;
        }

        public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse setWebsiteList(String websiteList) {
            this.websiteList = websiteList;
            return this;
        }
        public String getWebsiteList() {
            return this.websiteList;
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
