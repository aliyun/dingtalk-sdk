// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkrecord_1_0.models;

import com.aliyun.tea.*;

public class CountWorkRecordRequest extends TeaModel {
    // userId
    @NameInMap("userId")
    public String userId;

    public static CountWorkRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        CountWorkRecordRequest self = new CountWorkRecordRequest();
        return TeaModel.build(map, self);
    }

    public CountWorkRecordRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
