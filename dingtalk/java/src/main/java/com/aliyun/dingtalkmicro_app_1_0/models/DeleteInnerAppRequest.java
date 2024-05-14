// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteInnerAppRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUnionId")
    public String opUnionId;

    public static DeleteInnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteInnerAppRequest self = new DeleteInnerAppRequest();
        return TeaModel.build(map, self);
    }

    public DeleteInnerAppRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

}
