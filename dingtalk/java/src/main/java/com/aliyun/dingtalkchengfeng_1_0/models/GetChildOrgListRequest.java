// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetChildOrgListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("deptCode")
    public String deptCode;

    public static GetChildOrgListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetChildOrgListRequest self = new GetChildOrgListRequest();
        return TeaModel.build(map, self);
    }

    public GetChildOrgListRequest setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

}
