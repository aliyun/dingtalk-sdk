// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class GetMiniAppMetaDataRequest extends TeaModel {
    @NameInMap("bundleId")
    public String bundleId;

    @NameInMap("bundleIdTableGmtModified")
    public java.util.Map<String, ?> bundleIdTableGmtModified;

    @NameInMap("fromAppName")
    public String fromAppName;

    @NameInMap("miniAppIdTableGmtModified")
    public java.util.Map<String, ?> miniAppIdTableGmtModified;

    public static GetMiniAppMetaDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMiniAppMetaDataRequest self = new GetMiniAppMetaDataRequest();
        return TeaModel.build(map, self);
    }

    public GetMiniAppMetaDataRequest setBundleId(String bundleId) {
        this.bundleId = bundleId;
        return this;
    }
    public String getBundleId() {
        return this.bundleId;
    }

    public GetMiniAppMetaDataRequest setBundleIdTableGmtModified(java.util.Map<String, ?> bundleIdTableGmtModified) {
        this.bundleIdTableGmtModified = bundleIdTableGmtModified;
        return this;
    }
    public java.util.Map<String, ?> getBundleIdTableGmtModified() {
        return this.bundleIdTableGmtModified;
    }

    public GetMiniAppMetaDataRequest setFromAppName(String fromAppName) {
        this.fromAppName = fromAppName;
        return this;
    }
    public String getFromAppName() {
        return this.fromAppName;
    }

    public GetMiniAppMetaDataRequest setMiniAppIdTableGmtModified(java.util.Map<String, ?> miniAppIdTableGmtModified) {
        this.miniAppIdTableGmtModified = miniAppIdTableGmtModified;
        return this;
    }
    public java.util.Map<String, ?> getMiniAppIdTableGmtModified() {
        return this.miniAppIdTableGmtModified;
    }

}
