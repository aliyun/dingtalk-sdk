// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUuidByDentryIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1L</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    public static GetUuidByDentryIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUuidByDentryIdRequest self = new GetUuidByDentryIdRequest();
        return TeaModel.build(map, self);
    }

    public GetUuidByDentryIdRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public GetUuidByDentryIdRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

}
