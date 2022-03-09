// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteKeyResultRequest extends TeaModel {
    @NameInMap("krId")
    public java.io.InputStream krId;

    @NameInMap("ownerId")
    public java.io.InputStream ownerId;

    public static DeleteKeyResultRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteKeyResultRequest self = new DeleteKeyResultRequest();
        return TeaModel.build(map, self);
    }

    public DeleteKeyResultRequest setKrId(java.io.InputStream krId) {
        this.krId = krId;
        return this;
    }
    public java.io.InputStream getKrId() {
        return this.krId;
    }

    public DeleteKeyResultRequest setOwnerId(java.io.InputStream ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public java.io.InputStream getOwnerId() {
        return this.ownerId;
    }

}
