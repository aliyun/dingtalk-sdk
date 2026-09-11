// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUuidByIdOrUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>NVQ0MmFhZDAyYmRkYjM4Yw</p>
     */
    @NameInMap("idOrUrl")
    public String idOrUrl;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static GetUuidByIdOrUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUuidByIdOrUrlRequest self = new GetUuidByIdOrUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetUuidByIdOrUrlRequest setIdOrUrl(String idOrUrl) {
        this.idOrUrl = idOrUrl;
        return this;
    }
    public String getIdOrUrl() {
        return this.idOrUrl;
    }

    public GetUuidByIdOrUrlRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
