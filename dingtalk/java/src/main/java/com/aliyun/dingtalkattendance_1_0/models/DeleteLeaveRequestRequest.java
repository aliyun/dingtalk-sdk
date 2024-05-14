// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DeleteLeaveRequestRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outerId")
    public String outerId;

    public static DeleteLeaveRequestRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteLeaveRequestRequest self = new DeleteLeaveRequestRequest();
        return TeaModel.build(map, self);
    }

    public DeleteLeaveRequestRequest setOuterId(String outerId) {
        this.outerId = outerId;
        return this;
    }
    public String getOuterId() {
        return this.outerId;
    }

}
