// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsvMetadataQueryRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("objectCode")
    public String objectCode;

    public static IsvMetadataQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        IsvMetadataQueryRequest self = new IsvMetadataQueryRequest();
        return TeaModel.build(map, self);
    }

    public IsvMetadataQueryRequest setObjectCode(String objectCode) {
        this.objectCode = objectCode;
        return this;
    }
    public String getObjectCode() {
        return this.objectCode;
    }

}
