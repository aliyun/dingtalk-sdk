// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class UpdateAppVisibleScopeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("visibleDeptIds")
    public java.util.List<Long> visibleDeptIds;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("visibleScopeType")
    public String visibleScopeType;

    @NameInMap("visibleUserIds")
    public java.util.List<String> visibleUserIds;

    public static UpdateAppVisibleScopeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppVisibleScopeRequest self = new UpdateAppVisibleScopeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAppVisibleScopeRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public UpdateAppVisibleScopeRequest setVisibleDeptIds(java.util.List<Long> visibleDeptIds) {
        this.visibleDeptIds = visibleDeptIds;
        return this;
    }
    public java.util.List<Long> getVisibleDeptIds() {
        return this.visibleDeptIds;
    }

    public UpdateAppVisibleScopeRequest setVisibleScopeType(String visibleScopeType) {
        this.visibleScopeType = visibleScopeType;
        return this;
    }
    public String getVisibleScopeType() {
        return this.visibleScopeType;
    }

    public UpdateAppVisibleScopeRequest setVisibleUserIds(java.util.List<String> visibleUserIds) {
        this.visibleUserIds = visibleUserIds;
        return this;
    }
    public java.util.List<String> getVisibleUserIds() {
        return this.visibleUserIds;
    }

}
