// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateAuxiliaryStatusRequest extends TeaModel {
    @NameInMap("auxiliaryId")
    public String auxiliaryId;

    @NameInMap("auxiliaryType")
    public String auxiliaryType;

    @NameInMap("operateType")
    public String operateType;

    @NameInMap("userId")
    public String userId;

    public static UpdateAuxiliaryStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateAuxiliaryStatusRequest self = new UpdateAuxiliaryStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateAuxiliaryStatusRequest setAuxiliaryId(String auxiliaryId) {
        this.auxiliaryId = auxiliaryId;
        return this;
    }
    public String getAuxiliaryId() {
        return this.auxiliaryId;
    }

    public UpdateAuxiliaryStatusRequest setAuxiliaryType(String auxiliaryType) {
        this.auxiliaryType = auxiliaryType;
        return this;
    }
    public String getAuxiliaryType() {
        return this.auxiliaryType;
    }

    public UpdateAuxiliaryStatusRequest setOperateType(String operateType) {
        this.operateType = operateType;
        return this;
    }
    public String getOperateType() {
        return this.operateType;
    }

    public UpdateAuxiliaryStatusRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
