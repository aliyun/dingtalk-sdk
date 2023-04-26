// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivilegeInfoRequest extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    public static GetPrivilegeInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrivilegeInfoRequest self = new GetPrivilegeInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPrivilegeInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
