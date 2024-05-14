// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetAllAuthCubesResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("count")
    public Long count;

    @NameInMap("result")
    public java.util.List<GetAllAuthCubesResponseBodyResult> result;

    public static GetAllAuthCubesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllAuthCubesResponseBody self = new GetAllAuthCubesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllAuthCubesResponseBody setCount(Long count) {
        this.count = count;
        return this;
    }
    public Long getCount() {
        return this.count;
    }

    public GetAllAuthCubesResponseBody setResult(java.util.List<GetAllAuthCubesResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetAllAuthCubesResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetAllAuthCubesResponseBodyResultCubeDataRanges extends TeaModel {
        @NameInMap("classifiedCode")
        public String classifiedCode;

        @NameInMap("conditionKey")
        public String conditionKey;

        @NameInMap("conditionValue")
        public java.util.List<?> conditionValue;

        @NameInMap("elementCode")
        public String elementCode;

        @NameInMap("elementType")
        public String elementType;

        @NameInMap("operator")
        public String operator;

        public static GetAllAuthCubesResponseBodyResultCubeDataRanges build(java.util.Map<String, ?> map) throws Exception {
            GetAllAuthCubesResponseBodyResultCubeDataRanges self = new GetAllAuthCubesResponseBodyResultCubeDataRanges();
            return TeaModel.build(map, self);
        }

        public GetAllAuthCubesResponseBodyResultCubeDataRanges setClassifiedCode(String classifiedCode) {
            this.classifiedCode = classifiedCode;
            return this;
        }
        public String getClassifiedCode() {
            return this.classifiedCode;
        }

        public GetAllAuthCubesResponseBodyResultCubeDataRanges setConditionKey(String conditionKey) {
            this.conditionKey = conditionKey;
            return this;
        }
        public String getConditionKey() {
            return this.conditionKey;
        }

        public GetAllAuthCubesResponseBodyResultCubeDataRanges setConditionValue(java.util.List<?> conditionValue) {
            this.conditionValue = conditionValue;
            return this;
        }
        public java.util.List<?> getConditionValue() {
            return this.conditionValue;
        }

        public GetAllAuthCubesResponseBodyResultCubeDataRanges setElementCode(String elementCode) {
            this.elementCode = elementCode;
            return this;
        }
        public String getElementCode() {
            return this.elementCode;
        }

        public GetAllAuthCubesResponseBodyResultCubeDataRanges setElementType(String elementType) {
            this.elementType = elementType;
            return this;
        }
        public String getElementType() {
            return this.elementType;
        }

        public GetAllAuthCubesResponseBodyResultCubeDataRanges setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

    }

    public static class GetAllAuthCubesResponseBodyResultUserInformation extends TeaModel {
        @NameInMap("authProvider")
        public String authProvider;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("name")
        public String name;

        @NameInMap("nickName")
        public String nickName;

        @NameInMap("realmId")
        public Long realmId;

        @NameInMap("refererNamespaceCode")
        public String refererNamespaceCode;

        @NameInMap("showName")
        public String showName;

        @NameInMap("workNo")
        public String workNo;

        public static GetAllAuthCubesResponseBodyResultUserInformation build(java.util.Map<String, ?> map) throws Exception {
            GetAllAuthCubesResponseBodyResultUserInformation self = new GetAllAuthCubesResponseBodyResultUserInformation();
            return TeaModel.build(map, self);
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setAuthProvider(String authProvider) {
            this.authProvider = authProvider;
            return this;
        }
        public String getAuthProvider() {
            return this.authProvider;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setRealmId(Long realmId) {
            this.realmId = realmId;
            return this;
        }
        public Long getRealmId() {
            return this.realmId;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setRefererNamespaceCode(String refererNamespaceCode) {
            this.refererNamespaceCode = refererNamespaceCode;
            return this;
        }
        public String getRefererNamespaceCode() {
            return this.refererNamespaceCode;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setShowName(String showName) {
            this.showName = showName;
            return this;
        }
        public String getShowName() {
            return this.showName;
        }

        public GetAllAuthCubesResponseBodyResultUserInformation setWorkNo(String workNo) {
            this.workNo = workNo;
            return this;
        }
        public String getWorkNo() {
            return this.workNo;
        }

    }

    public static class GetAllAuthCubesResponseBodyResult extends TeaModel {
        @NameInMap("apappliedCount")
        public Integer apappliedCount;

        @NameInMap("appCode")
        public String appCode;

        @NameInMap("appInstanceCode")
        public String appInstanceCode;

        @NameInMap("appStoreCode")
        public String appStoreCode;

        @NameInMap("authMode")
        public String authMode;

        @NameInMap("authorizationType")
        public Integer authorizationType;

        @NameInMap("businessProcessCode")
        public String businessProcessCode;

        @NameInMap("categoriesFirst")
        public String categoriesFirst;

        @NameInMap("categoriesSecond")
        public String categoriesSecond;

        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("cubeAuthType")
        public String cubeAuthType;

        @NameInMap("cubeCode")
        public String cubeCode;

        @NameInMap("cubeDataRange")
        public String cubeDataRange;

        @NameInMap("cubeDataRanges")
        public java.util.List<GetAllAuthCubesResponseBodyResultCubeDataRanges> cubeDataRanges;

        @NameInMap("cubeSource")
        public String cubeSource;

        @NameInMap("dataCacheTimeConfiguration")
        public String dataCacheTimeConfiguration;

        @NameInMap("dataflowCode")
        public String dataflowCode;

        @NameInMap("description")
        public String description;

        @NameInMap("domainCode")
        public String domainCode;

        @NameInMap("enableCache")
        public Boolean enableCache;

        @NameInMap("id")
        public Long id;

        @NameInMap("isNeedApplication")
        public String isNeedApplication;

        @NameInMap("isTrend")
        public String isTrend;

        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        @NameInMap("modifier")
        public String modifier;

        @NameInMap("name")
        public String name;

        @NameInMap("namespaceCode")
        public String namespaceCode;

        @NameInMap("owner")
        public String owner;

        @NameInMap("sharedDataSet")
        public Boolean sharedDataSet;

        @NameInMap("tenantCorpId")
        public String tenantCorpId;

        @NameInMap("type")
        public String type;

        @NameInMap("userInformation")
        public GetAllAuthCubesResponseBodyResultUserInformation userInformation;

        public static GetAllAuthCubesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetAllAuthCubesResponseBodyResult self = new GetAllAuthCubesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetAllAuthCubesResponseBodyResult setApappliedCount(Integer apappliedCount) {
            this.apappliedCount = apappliedCount;
            return this;
        }
        public Integer getApappliedCount() {
            return this.apappliedCount;
        }

        public GetAllAuthCubesResponseBodyResult setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public GetAllAuthCubesResponseBodyResult setAppInstanceCode(String appInstanceCode) {
            this.appInstanceCode = appInstanceCode;
            return this;
        }
        public String getAppInstanceCode() {
            return this.appInstanceCode;
        }

        public GetAllAuthCubesResponseBodyResult setAppStoreCode(String appStoreCode) {
            this.appStoreCode = appStoreCode;
            return this;
        }
        public String getAppStoreCode() {
            return this.appStoreCode;
        }

        public GetAllAuthCubesResponseBodyResult setAuthMode(String authMode) {
            this.authMode = authMode;
            return this;
        }
        public String getAuthMode() {
            return this.authMode;
        }

        public GetAllAuthCubesResponseBodyResult setAuthorizationType(Integer authorizationType) {
            this.authorizationType = authorizationType;
            return this;
        }
        public Integer getAuthorizationType() {
            return this.authorizationType;
        }

        public GetAllAuthCubesResponseBodyResult setBusinessProcessCode(String businessProcessCode) {
            this.businessProcessCode = businessProcessCode;
            return this;
        }
        public String getBusinessProcessCode() {
            return this.businessProcessCode;
        }

        public GetAllAuthCubesResponseBodyResult setCategoriesFirst(String categoriesFirst) {
            this.categoriesFirst = categoriesFirst;
            return this;
        }
        public String getCategoriesFirst() {
            return this.categoriesFirst;
        }

        public GetAllAuthCubesResponseBodyResult setCategoriesSecond(String categoriesSecond) {
            this.categoriesSecond = categoriesSecond;
            return this;
        }
        public String getCategoriesSecond() {
            return this.categoriesSecond;
        }

        public GetAllAuthCubesResponseBodyResult setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetAllAuthCubesResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public GetAllAuthCubesResponseBodyResult setCubeAuthType(String cubeAuthType) {
            this.cubeAuthType = cubeAuthType;
            return this;
        }
        public String getCubeAuthType() {
            return this.cubeAuthType;
        }

        public GetAllAuthCubesResponseBodyResult setCubeCode(String cubeCode) {
            this.cubeCode = cubeCode;
            return this;
        }
        public String getCubeCode() {
            return this.cubeCode;
        }

        public GetAllAuthCubesResponseBodyResult setCubeDataRange(String cubeDataRange) {
            this.cubeDataRange = cubeDataRange;
            return this;
        }
        public String getCubeDataRange() {
            return this.cubeDataRange;
        }

        public GetAllAuthCubesResponseBodyResult setCubeDataRanges(java.util.List<GetAllAuthCubesResponseBodyResultCubeDataRanges> cubeDataRanges) {
            this.cubeDataRanges = cubeDataRanges;
            return this;
        }
        public java.util.List<GetAllAuthCubesResponseBodyResultCubeDataRanges> getCubeDataRanges() {
            return this.cubeDataRanges;
        }

        public GetAllAuthCubesResponseBodyResult setCubeSource(String cubeSource) {
            this.cubeSource = cubeSource;
            return this;
        }
        public String getCubeSource() {
            return this.cubeSource;
        }

        public GetAllAuthCubesResponseBodyResult setDataCacheTimeConfiguration(String dataCacheTimeConfiguration) {
            this.dataCacheTimeConfiguration = dataCacheTimeConfiguration;
            return this;
        }
        public String getDataCacheTimeConfiguration() {
            return this.dataCacheTimeConfiguration;
        }

        public GetAllAuthCubesResponseBodyResult setDataflowCode(String dataflowCode) {
            this.dataflowCode = dataflowCode;
            return this;
        }
        public String getDataflowCode() {
            return this.dataflowCode;
        }

        public GetAllAuthCubesResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetAllAuthCubesResponseBodyResult setDomainCode(String domainCode) {
            this.domainCode = domainCode;
            return this;
        }
        public String getDomainCode() {
            return this.domainCode;
        }

        public GetAllAuthCubesResponseBodyResult setEnableCache(Boolean enableCache) {
            this.enableCache = enableCache;
            return this;
        }
        public Boolean getEnableCache() {
            return this.enableCache;
        }

        public GetAllAuthCubesResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetAllAuthCubesResponseBodyResult setIsNeedApplication(String isNeedApplication) {
            this.isNeedApplication = isNeedApplication;
            return this;
        }
        public String getIsNeedApplication() {
            return this.isNeedApplication;
        }

        public GetAllAuthCubesResponseBodyResult setIsTrend(String isTrend) {
            this.isTrend = isTrend;
            return this;
        }
        public String getIsTrend() {
            return this.isTrend;
        }

        public GetAllAuthCubesResponseBodyResult setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public GetAllAuthCubesResponseBodyResult setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public GetAllAuthCubesResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAllAuthCubesResponseBodyResult setNamespaceCode(String namespaceCode) {
            this.namespaceCode = namespaceCode;
            return this;
        }
        public String getNamespaceCode() {
            return this.namespaceCode;
        }

        public GetAllAuthCubesResponseBodyResult setOwner(String owner) {
            this.owner = owner;
            return this;
        }
        public String getOwner() {
            return this.owner;
        }

        public GetAllAuthCubesResponseBodyResult setSharedDataSet(Boolean sharedDataSet) {
            this.sharedDataSet = sharedDataSet;
            return this;
        }
        public Boolean getSharedDataSet() {
            return this.sharedDataSet;
        }

        public GetAllAuthCubesResponseBodyResult setTenantCorpId(String tenantCorpId) {
            this.tenantCorpId = tenantCorpId;
            return this;
        }
        public String getTenantCorpId() {
            return this.tenantCorpId;
        }

        public GetAllAuthCubesResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetAllAuthCubesResponseBodyResult setUserInformation(GetAllAuthCubesResponseBodyResultUserInformation userInformation) {
            this.userInformation = userInformation;
            return this;
        }
        public GetAllAuthCubesResponseBodyResultUserInformation getUserInformation() {
            return this.userInformation;
        }

    }

}
