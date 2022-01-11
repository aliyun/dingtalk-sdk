// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class CheckWritePermissionRequest extends TeaModel {
    // category
    @NameInMap("category")
    public String category;

    // entityIds
    @NameInMap("entityIds")
    public java.util.List<Long> entityIds;

    // opUserId
    @NameInMap("opUserId")
    public String opUserId;

    // resourceKey
    @NameInMap("resourceKey")
    public String resourceKey;

    // corpId
    @NameInMap("corpId")
    public String corpId;

    public static CheckWritePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        CheckWritePermissionRequest self = new CheckWritePermissionRequest();
        return TeaModel.build(map, self);
    }

    public CheckWritePermissionRequest setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public CheckWritePermissionRequest setEntityIds(java.util.List<Long> entityIds) {
        this.entityIds = entityIds;
        return this;
    }
    public java.util.List<Long> getEntityIds() {
        return this.entityIds;
    }

    public CheckWritePermissionRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public CheckWritePermissionRequest setResourceKey(String resourceKey) {
        this.resourceKey = resourceKey;
        return this;
    }
    public String getResourceKey() {
        return this.resourceKey;
    }

    public CheckWritePermissionRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
