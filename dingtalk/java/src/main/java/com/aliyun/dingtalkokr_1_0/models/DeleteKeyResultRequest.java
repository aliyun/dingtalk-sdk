// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteKeyResultRequest extends TeaModel {
    /**
     * <p>当前 KR id。</p>
     */
    @NameInMap("krId")
    public String krId;

    /**
     * <p>当前用户的userId。</p>
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
