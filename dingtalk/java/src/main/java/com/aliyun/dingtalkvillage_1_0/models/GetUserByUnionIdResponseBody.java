// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetUserByUnionIdResponseBody extends TeaModel {
    /**
     * <p>联系类型，0表示企业内部员工，1表示企业外部联系人</p>
     */
    @NameInMap("contactType")
    public Integer contactType;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetUserByUnionIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserByUnionIdResponseBody self = new GetUserByUnionIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserByUnionIdResponseBody setContactType(Integer contactType) {
        this.contactType = contactType;
        return this;
    }
    public Integer getContactType() {
        return this.contactType;
    }

    public GetUserByUnionIdResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
