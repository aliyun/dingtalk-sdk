// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetDeveloperMetadataRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static GetDeveloperMetadataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDeveloperMetadataRequest self = new GetDeveloperMetadataRequest();
        return TeaModel.build(map, self);
    }

    public GetDeveloperMetadataRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
