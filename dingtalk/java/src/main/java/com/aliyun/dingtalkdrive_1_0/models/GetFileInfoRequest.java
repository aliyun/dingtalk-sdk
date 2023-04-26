// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetFileInfoRequest extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    public static GetFileInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileInfoRequest self = new GetFileInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFileInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
