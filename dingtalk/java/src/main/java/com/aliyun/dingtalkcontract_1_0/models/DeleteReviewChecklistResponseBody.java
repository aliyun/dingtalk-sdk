// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class DeleteReviewChecklistResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    public static DeleteReviewChecklistResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteReviewChecklistResponseBody self = new DeleteReviewChecklistResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteReviewChecklistResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

}
