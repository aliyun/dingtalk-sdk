// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteLeadsResponseBody extends TeaModel {
    @NameInMap("outLeadsIds")
    public java.util.List<String> outLeadsIds;

    public static DeleteLeadsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteLeadsResponseBody self = new DeleteLeadsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteLeadsResponseBody setOutLeadsIds(java.util.List<String> outLeadsIds) {
        this.outLeadsIds = outLeadsIds;
        return this;
    }
    public java.util.List<String> getOutLeadsIds() {
        return this.outLeadsIds;
    }

}
