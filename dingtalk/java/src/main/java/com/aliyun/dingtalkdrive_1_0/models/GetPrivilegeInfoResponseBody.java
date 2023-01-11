// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivilegeInfoResponseBody extends TeaModel {
    /**
     * <p>类型列表</p>
     */
    @NameInMap("types")
    public java.util.List<String> types;

    public static GetPrivilegeInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrivilegeInfoResponseBody self = new GetPrivilegeInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrivilegeInfoResponseBody setTypes(java.util.List<String> types) {
        this.types = types;
        return this;
    }
    public java.util.List<String> getTypes() {
        return this.types;
    }

}
