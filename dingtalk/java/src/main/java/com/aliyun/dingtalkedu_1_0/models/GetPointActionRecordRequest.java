// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetPointActionRecordRequest extends TeaModel {
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("pointType")
    public String pointType;

    public static GetPointActionRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPointActionRecordRequest self = new GetPointActionRecordRequest();
        return TeaModel.build(map, self);
    }

    public GetPointActionRecordRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public GetPointActionRecordRequest setPointType(String pointType) {
        this.pointType = pointType;
        return this;
    }
    public String getPointType() {
        return this.pointType;
    }

}
