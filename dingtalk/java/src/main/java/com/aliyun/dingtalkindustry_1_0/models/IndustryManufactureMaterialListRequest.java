// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMaterialListRequest extends TeaModel {
    @NameInMap("tokenGrantType")
    public Long tokenGrantType;

    @NameInMap("corpId")
    public String corpId;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("materialNo")
    public String materialNo;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("microappAgentId")
    public Long microappAgentId;

    @NameInMap("cursor")
    public Long cursor;

    @NameInMap("appName")
    public String appName;

    @NameInMap("orgId")
    public Long orgId;

    @NameInMap("appId")
    public Long appId;

    @NameInMap("suiteKey")
    public String suiteKey;

    @NameInMap("appIds")
    public java.util.List<Long> appIds;

    @NameInMap("currentPage")
    public Long currentPage;

    @NameInMap("isvOrgId")
    public Long isvOrgId;

    public static IndustryManufactureMaterialListRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMaterialListRequest self = new IndustryManufactureMaterialListRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMaterialListRequest setTokenGrantType(Long tokenGrantType) {
        this.tokenGrantType = tokenGrantType;
        return this;
    }
    public Long getTokenGrantType() {
        return this.tokenGrantType;
    }

    public IndustryManufactureMaterialListRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public IndustryManufactureMaterialListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public IndustryManufactureMaterialListRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public IndustryManufactureMaterialListRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public IndustryManufactureMaterialListRequest setMaterialNo(String materialNo) {
        this.materialNo = materialNo;
        return this;
    }
    public String getMaterialNo() {
        return this.materialNo;
    }

    public IndustryManufactureMaterialListRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public IndustryManufactureMaterialListRequest setMicroappAgentId(Long microappAgentId) {
        this.microappAgentId = microappAgentId;
        return this;
    }
    public Long getMicroappAgentId() {
        return this.microappAgentId;
    }

    public IndustryManufactureMaterialListRequest setCursor(Long cursor) {
        this.cursor = cursor;
        return this;
    }
    public Long getCursor() {
        return this.cursor;
    }

    public IndustryManufactureMaterialListRequest setAppName(String appName) {
        this.appName = appName;
        return this;
    }
    public String getAppName() {
        return this.appName;
    }

    public IndustryManufactureMaterialListRequest setOrgId(Long orgId) {
        this.orgId = orgId;
        return this;
    }
    public Long getOrgId() {
        return this.orgId;
    }

    public IndustryManufactureMaterialListRequest setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public IndustryManufactureMaterialListRequest setSuiteKey(String suiteKey) {
        this.suiteKey = suiteKey;
        return this;
    }
    public String getSuiteKey() {
        return this.suiteKey;
    }

    public IndustryManufactureMaterialListRequest setAppIds(java.util.List<Long> appIds) {
        this.appIds = appIds;
        return this;
    }
    public java.util.List<Long> getAppIds() {
        return this.appIds;
    }

    public IndustryManufactureMaterialListRequest setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public IndustryManufactureMaterialListRequest setIsvOrgId(Long isvOrgId) {
        this.isvOrgId = isvOrgId;
        return this;
    }
    public Long getIsvOrgId() {
        return this.isvOrgId;
    }

}
