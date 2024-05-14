// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetAsyncTaskInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetAsyncTaskInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncTaskInfoRequest self = new GetAsyncTaskInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetAsyncTaskInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
