// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class AddRetentionRecordResponseBody extends TeaModel {
    @NameInMap("isSuccess")
    public Boolean isSuccess;

    public static AddRetentionRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRetentionRecordResponseBody self = new AddRetentionRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRetentionRecordResponseBody setIsSuccess(Boolean isSuccess) {
        this.isSuccess = isSuccess;
        return this;
    }
    public Boolean getIsSuccess() {
        return this.isSuccess;
    }

}
