// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteLeadsRequest extends TeaModel {
    @NameInMap("outLeadsIds")
    public java.util.List<String> outLeadsIds;

    public static DeleteLeadsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteLeadsRequest self = new DeleteLeadsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteLeadsRequest setOutLeadsIds(java.util.List<String> outLeadsIds) {
        this.outLeadsIds = outLeadsIds;
        return this;
    }
    public java.util.List<String> getOutLeadsIds() {
        return this.outLeadsIds;
    }

}
