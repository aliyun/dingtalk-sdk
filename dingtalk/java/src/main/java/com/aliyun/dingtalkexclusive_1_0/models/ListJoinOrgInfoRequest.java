// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListJoinOrgInfoRequest extends TeaModel {
    @NameInMap("mobile")
    public String mobile;

    public static ListJoinOrgInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        ListJoinOrgInfoRequest self = new ListJoinOrgInfoRequest();
        return TeaModel.build(map, self);
    }

    public ListJoinOrgInfoRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

}
