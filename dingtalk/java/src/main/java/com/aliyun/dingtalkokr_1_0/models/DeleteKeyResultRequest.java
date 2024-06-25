// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteKeyResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>4d2d</p>
     */
    @NameInMap("krId")
    public String krId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>06186238011033616</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteKeyResultRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteKeyResultRequest self = new DeleteKeyResultRequest();
        return TeaModel.build(map, self);
    }

    public DeleteKeyResultRequest setKrId(String krId) {
        this.krId = krId;
        return this;
    }
    public String getKrId() {
        return this.krId;
    }

    public DeleteKeyResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
