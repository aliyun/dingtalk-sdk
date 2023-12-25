// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class ModifyWorkbenchBadgeRequest extends TeaModel {
    @NameInMap("bizIdList")
    public java.util.List<String> bizIdList;

    @NameInMap("isAdded")
    public Boolean isAdded;

    @NameInMap("modifyMode")
    public String modifyMode;

    @NameInMap("redDotRelationId")
    public String redDotRelationId;

    @NameInMap("redDotType")
    public String redDotType;

    @NameInMap("userId")
    public String userId;

    public static ModifyWorkbenchBadgeRequest build(java.util.Map<String, ?> map) throws Exception {
        ModifyWorkbenchBadgeRequest self = new ModifyWorkbenchBadgeRequest();
        return TeaModel.build(map, self);
    }

    public ModifyWorkbenchBadgeRequest setBizIdList(java.util.List<String> bizIdList) {
        this.bizIdList = bizIdList;
        return this;
    }
    public java.util.List<String> getBizIdList() {
        return this.bizIdList;
    }

    public ModifyWorkbenchBadgeRequest setIsAdded(Boolean isAdded) {
        this.isAdded = isAdded;
        return this;
    }
    public Boolean getIsAdded() {
        return this.isAdded;
    }

    public ModifyWorkbenchBadgeRequest setModifyMode(String modifyMode) {
        this.modifyMode = modifyMode;
        return this;
    }
    public String getModifyMode() {
        return this.modifyMode;
    }

    public ModifyWorkbenchBadgeRequest setRedDotRelationId(String redDotRelationId) {
        this.redDotRelationId = redDotRelationId;
        return this;
    }
    public String getRedDotRelationId() {
        return this.redDotRelationId;
    }

    public ModifyWorkbenchBadgeRequest setRedDotType(String redDotType) {
        this.redDotType = redDotType;
        return this;
    }
    public String getRedDotType() {
        return this.redDotType;
    }

    public ModifyWorkbenchBadgeRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
