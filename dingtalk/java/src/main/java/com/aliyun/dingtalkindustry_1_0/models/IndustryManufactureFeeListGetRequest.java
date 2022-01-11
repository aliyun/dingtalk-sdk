// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureFeeListGetRequest extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("appIds")
    public java.util.List<Long> appIds;

    @NameInMap("appName")
    public String appName;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("isvOrgId")
    public Long isvOrgId;

    @NameInMap("materialNo")
    public String materialNo;

    @NameInMap("microappAgentId")
    public Long microappAgentId;

    @NameInMap("orgId")
    public Long orgId;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("productionTaskNo")
    public String productionTaskNo;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("suiteKey")
    public String suiteKey;

    @NameInMap("tokenGrantType")
    public Integer tokenGrantType;

    @NameInMap("type")
    public String type;

    public static IndustryManufactureFeeListGetRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureFeeListGetRequest self = new IndustryManufactureFeeListGetRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureFeeListGetRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public IndustryManufactureFeeListGetRequest setAppIds(java.util.List<Long> appIds) {
        this.appIds = appIds;
        return this;
    }
    public java.util.List<Long> getAppIds() {
        return this.appIds;
    }

    public IndustryManufactureFeeListGetRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public IndustryManufactureFeeListGetRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public IndustryManufactureFeeListGetRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public IndustryManufactureFeeListGetRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public IndustryManufactureFeeListGetRequest setIsvOrgId(Long isvOrgId) {
        this.isvOrgId = isvOrgId;
        return this;
    }
    public Long getIsvOrgId() {
        return this.isvOrgId;
    }

    public IndustryManufactureFeeListGetRequest setMaterialNo(String materialNo) {
        this.materialNo = materialNo;
        return this;
    }
    public String getMaterialNo() {
        return this.materialNo;
    }

    public IndustryManufactureFeeListGetRequest setMicroappAgentId(Long microappAgentId) {
        this.microappAgentId = microappAgentId;
        return this;
    }
    public Long getMicroappAgentId() {
        return this.microappAgentId;
    }

    public IndustryManufactureFeeListGetRequest setOrgId(Long orgId) {
        this.orgId = orgId;
        return this;
    }
    public Long getOrgId() {
        return this.orgId;
    }

    public IndustryManufactureFeeListGetRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public IndustryManufactureFeeListGetRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public IndustryManufactureFeeListGetRequest setProductionTaskNo(String productionTaskNo) {
        this.productionTaskNo = productionTaskNo;
        return this;
    }
    public String getProductionTaskNo() {
        return this.productionTaskNo;
    }

    public IndustryManufactureFeeListGetRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public IndustryManufactureFeeListGetRequest setSuiteKey(String suiteKey) {
        this.suiteKey = suiteKey;
        return this;
    }
    public String getSuiteKey() {
        return this.suiteKey;
    }

    public IndustryManufactureFeeListGetRequest setTokenGrantType(Integer tokenGrantType) {
        this.tokenGrantType = tokenGrantType;
        return this;
    }
    public Integer getTokenGrantType() {
        return this.tokenGrantType;
    }

    public IndustryManufactureFeeListGetRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
