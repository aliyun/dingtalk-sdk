// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryMmanufactureMaterialCostGetRequest extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("materialNo")
    public String materialNo;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("tokenGrantType")
    public Integer tokenGrantType;

    @NameInMap("orgId")
    public Long orgId;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("isvOrgId")
    public Long isvOrgId;

    @NameInMap("suiteKey")
    public String suiteKey;

    @NameInMap("microappAgentId")
    public Long microappAgentId;

    @NameInMap("appIds")
    public java.util.List<Long> appIds;

    @NameInMap("appId")
    public Long appId;

    @NameInMap("appName")
    public String appName;

    public static IndustryMmanufactureMaterialCostGetRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryMmanufactureMaterialCostGetRequest self = new IndustryMmanufactureMaterialCostGetRequest();
        return TeaModel.build(map, self);
    }

    public IndustryMmanufactureMaterialCostGetRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public IndustryMmanufactureMaterialCostGetRequest setMaterialNo(String materialNo) {
        this.materialNo = materialNo;
        return this;
    }
    public String getMaterialNo() {
        return this.materialNo;
    }

    public IndustryMmanufactureMaterialCostGetRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public IndustryMmanufactureMaterialCostGetRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public IndustryMmanufactureMaterialCostGetRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public IndustryMmanufactureMaterialCostGetRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public IndustryMmanufactureMaterialCostGetRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public IndustryMmanufactureMaterialCostGetRequest setTokenGrantType(Integer tokenGrantType) {
        this.tokenGrantType = tokenGrantType;
        return this;
    }
    public Integer getTokenGrantType() {
        return this.tokenGrantType;
    }

    public IndustryMmanufactureMaterialCostGetRequest setOrgId(Long orgId) {
        this.orgId = orgId;
        return this;
    }
    public Long getOrgId() {
        return this.orgId;
    }

    public IndustryMmanufactureMaterialCostGetRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public IndustryMmanufactureMaterialCostGetRequest setIsvOrgId(Long isvOrgId) {
        this.isvOrgId = isvOrgId;
        return this;
    }
    public Long getIsvOrgId() {
        return this.isvOrgId;
    }

    public IndustryMmanufactureMaterialCostGetRequest setSuiteKey(String suiteKey) {
        this.suiteKey = suiteKey;
        return this;
    }
    public String getSuiteKey() {
        return this.suiteKey;
    }

    public IndustryMmanufactureMaterialCostGetRequest setMicroappAgentId(Long microappAgentId) {
        this.microappAgentId = microappAgentId;
        return this;
    }
    public Long getMicroappAgentId() {
        return this.microappAgentId;
    }

    public IndustryMmanufactureMaterialCostGetRequest setAppIds(java.util.List<Long> appIds) {
        this.appIds = appIds;
        return this;
    }
    public java.util.List<Long> getAppIds() {
        return this.appIds;
    }

    public IndustryMmanufactureMaterialCostGetRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public IndustryMmanufactureMaterialCostGetRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

}