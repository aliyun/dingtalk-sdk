// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class UndoDeletionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizIdList")
    public java.util.List<String> bizIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("redDotRelationId")
    public String redDotRelationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>workbench_component</p>
     */
    @NameInMap("redDotType")
    public String redDotType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UndoDeletionRequest build(java.util.Map<String, ?> map) throws Exception {
        UndoDeletionRequest self = new UndoDeletionRequest();
        return TeaModel.build(map, self);
    }

    public UndoDeletionRequest setBizIdList(java.util.List<String> bizIdList) {
        this.bizIdList = bizIdList;
        return this;
    }
    public java.util.List<String> getBizIdList() {
        return this.bizIdList;
    }

    public UndoDeletionRequest setRedDotRelationId(String redDotRelationId) {
        this.redDotRelationId = redDotRelationId;
        return this;
    }
    public String getRedDotRelationId() {
        return this.redDotRelationId;
    }

    public UndoDeletionRequest setRedDotType(String redDotType) {
        this.redDotType = redDotType;
        return this;
    }
    public String getRedDotType() {
        return this.redDotType;
    }

    public UndoDeletionRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
