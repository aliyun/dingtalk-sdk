// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFloatImagesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetFloatImagesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFloatImagesRequest self = new GetFloatImagesRequest();
        return TeaModel.build(map, self);
    }

    public GetFloatImagesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
