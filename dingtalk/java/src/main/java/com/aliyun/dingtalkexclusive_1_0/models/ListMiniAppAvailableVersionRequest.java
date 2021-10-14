// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppAvailableVersionRequest extends TeaModel {
    // 版本类型列表，0-开发版，1-灰度版，2-发布版，3-体验版
    @NameInMap("versionTypeSet")
    public java.util.List<Integer> versionTypeSet;

    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 分页数1
    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingCorpId")
    public String dingCorpId;

    @NameInMap("dingClientId")
    public String dingClientId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 小程序id
    @NameInMap("miniAppId")
    public String miniAppId;

    public static ListMiniAppAvailableVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMiniAppAvailableVersionRequest self = new ListMiniAppAvailableVersionRequest();
        return TeaModel.build(map, self);
    }

    public ListMiniAppAvailableVersionRequest setVersionTypeSet(java.util.List<Integer> versionTypeSet) {
        this.versionTypeSet = versionTypeSet;
        return this;
    }
    public java.util.List<Integer> getVersionTypeSet() {
        return this.versionTypeSet;
    }

    public ListMiniAppAvailableVersionRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListMiniAppAvailableVersionRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListMiniAppAvailableVersionRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public ListMiniAppAvailableVersionRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public ListMiniAppAvailableVersionRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public ListMiniAppAvailableVersionRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public ListMiniAppAvailableVersionRequest setDingClientId(String dingClientId) {
        this.dingClientId = dingClientId;
        return this;
    }
    public String getDingClientId() {
        return this.dingClientId;
    }

    public ListMiniAppAvailableVersionRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public ListMiniAppAvailableVersionRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

}
