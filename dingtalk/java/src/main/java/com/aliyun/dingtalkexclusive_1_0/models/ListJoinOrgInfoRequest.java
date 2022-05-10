// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListJoinOrgInfoRequest extends TeaModel {
    // 手机号码，企业内必须唯一，不可重复。如果是国际号码，请使用+xx-xxxxxx的格式。
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
