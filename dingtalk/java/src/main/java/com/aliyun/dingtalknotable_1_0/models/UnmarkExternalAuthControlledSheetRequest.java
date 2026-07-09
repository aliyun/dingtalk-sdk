// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UnmarkExternalAuthControlledSheetRequest extends TeaModel {
    @NameInMap("clientToken")
    public String clientToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UnmarkExternalAuthControlledSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        UnmarkExternalAuthControlledSheetRequest self = new UnmarkExternalAuthControlledSheetRequest();
        return TeaModel.build(map, self);
    }

    public UnmarkExternalAuthControlledSheetRequest setClientToken(String clientToken) {
        this.clientToken = clientToken;
        return this;
    }
    public String getClientToken() {
        return this.clientToken;
    }

    public UnmarkExternalAuthControlledSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
