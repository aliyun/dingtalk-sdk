// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetPropertyInfoRequest extends TeaModel {
    /**
     * <p>dingCropId</p>
     */
    @NameInMap("propertyCorpId")
    public String propertyCorpId;

    public static GetPropertyInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPropertyInfoRequest self = new GetPropertyInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPropertyInfoRequest setPropertyCorpId(String propertyCorpId) {
        this.propertyCorpId = propertyCorpId;
        return this;
    }
    public String getPropertyCorpId() {
        return this.propertyCorpId;
    }

}
