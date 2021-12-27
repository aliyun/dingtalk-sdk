// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetMySpaceInfoRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetMySpaceInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMySpaceInfoRequest self = new GetMySpaceInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetMySpaceInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
