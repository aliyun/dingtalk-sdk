// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListMiniAppAvailableVersionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>5000003</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     */
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
