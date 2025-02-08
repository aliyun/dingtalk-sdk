// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class DeleteMinutesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static DeleteMinutesRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMinutesRequest self = new DeleteMinutesRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMinutesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
