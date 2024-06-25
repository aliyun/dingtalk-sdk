// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetEmployeeInfoByWorkNoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>305932</p>
     */
    @NameInMap("workNo")
    public String workNo;

    public static GetEmployeeInfoByWorkNoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetEmployeeInfoByWorkNoRequest self = new GetEmployeeInfoByWorkNoRequest();
        return TeaModel.build(map, self);
    }

    public GetEmployeeInfoByWorkNoRequest setWorkNo(String workNo) {
        this.workNo = workNo;
        return this;
    }
    public String getWorkNo() {
        return this.workNo;
    }

}
