// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetOrgInfoRequest extends TeaModel {
    @NameInMap("deptCode")
    public String deptCode;

    public static GetOrgInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrgInfoRequest self = new GetOrgInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetOrgInfoRequest setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

}
