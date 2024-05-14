// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class ListAvaiableVersionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bundleId")
    public String bundleId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNum")
    public Integer pageNum;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("versionTypeSet")
    public java.util.List<Integer> versionTypeSet;

    public static ListAvaiableVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAvaiableVersionRequest self = new ListAvaiableVersionRequest();
        return TeaModel.build(map, self);
    }

    public ListAvaiableVersionRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public ListAvaiableVersionRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ListAvaiableVersionRequest setPageNum(Integer pageNum) {
        this.pageNum = pageNum;
        return this;
    }
    public Integer getPageNum() {
        return this.pageNum;
    }

    public ListAvaiableVersionRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListAvaiableVersionRequest setVersionTypeSet(java.util.List<Integer> versionTypeSet) {
        this.versionTypeSet = versionTypeSet;
        return this;
    }
    public java.util.List<Integer> getVersionTypeSet() {
        return this.versionTypeSet;
    }

}
