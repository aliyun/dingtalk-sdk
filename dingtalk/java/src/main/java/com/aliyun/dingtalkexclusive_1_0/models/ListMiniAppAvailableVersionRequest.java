// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppAvailableVersionRequest extends TeaModel {
    // 小程序id
    @NameInMap("miniAppId")
    public String miniAppId;

    // 分页数1
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 版本类型列表，0-开发版，1-灰度版，2-发布版，3-体验版
    @NameInMap("versionTypeSet")
    public java.util.List<Integer> versionTypeSet;

    public static ListMiniAppAvailableVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        ListMiniAppAvailableVersionRequest self = new ListMiniAppAvailableVersionRequest();
        return TeaModel.build(map, self);
    }

    public ListMiniAppAvailableVersionRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ListMiniAppAvailableVersionRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListMiniAppAvailableVersionRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListMiniAppAvailableVersionRequest setVersionTypeSet(java.util.List<Integer> versionTypeSet) {
        this.versionTypeSet = versionTypeSet;
        return this;
    }
    public java.util.List<Integer> getVersionTypeSet() {
        return this.versionTypeSet;
    }

}
