// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetManageProcessByStaffIdRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static GetManageProcessByStaffIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetManageProcessByStaffIdRequest self = new GetManageProcessByStaffIdRequest();
        return TeaModel.build(map, self);
    }

    public GetManageProcessByStaffIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
