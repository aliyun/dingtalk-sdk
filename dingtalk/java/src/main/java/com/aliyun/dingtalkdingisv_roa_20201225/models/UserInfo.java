// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class UserInfo extends TeaModel {
    // ces
    @NameInMap("Name")
    public String name;

    // ces
    @NameInMap("Address")
    public String address;

    // ces
    @NameInMap("Age")
    public String age;

    public static UserInfo build(java.util.Map<String, ?> map) throws Exception {
        UserInfo self = new UserInfo();
        return TeaModel.build(map, self);
    }

    public UserInfo setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UserInfo setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public UserInfo setAge(String age) {
        this.age = age;
        return this;
    }
    public String getAge() {
        return this.age;
    }

}
