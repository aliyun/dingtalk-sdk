// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateFulfilRecordResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("successInfo")
    public String successInfo;

    public static CreateFulfilRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFulfilRecordResponseBody self = new CreateFulfilRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFulfilRecordResponseBody setSuccessInfo(String successInfo) {
        this.successInfo = successInfo;
        return this;
    }
    public String getSuccessInfo() {
        return this.successInfo;
    }

}
