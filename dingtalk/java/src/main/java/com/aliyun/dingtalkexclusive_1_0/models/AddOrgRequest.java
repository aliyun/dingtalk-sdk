// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddOrgRequest extends TeaModel {
    // 手机号
    @NameInMap("mobileNum")
    public String mobileNum;

    // 组织名称
    @NameInMap("name")
    public String name;

    public static AddOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgRequest self = new AddOrgRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgRequest setMobileNum(String mobileNum) {
        this.mobileNum = mobileNum;
        return this;
    }
    public String getMobileNum() {
        return this.mobileNum;
    }

    public AddOrgRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
