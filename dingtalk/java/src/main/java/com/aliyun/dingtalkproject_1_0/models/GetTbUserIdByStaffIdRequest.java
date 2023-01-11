// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbUserIdByStaffIdRequest extends TeaModel {
    /**
     * <p>操作者userId</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    /**
     * <p>用户userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetTbUserIdByStaffIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTbUserIdByStaffIdRequest self = new GetTbUserIdByStaffIdRequest();
        return TeaModel.build(map, self);
    }

    public GetTbUserIdByStaffIdRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public GetTbUserIdByStaffIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
