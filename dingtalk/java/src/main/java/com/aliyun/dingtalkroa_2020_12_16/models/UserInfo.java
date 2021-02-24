// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkroa_2020_12_16.models;

import com.aliyun.tea.*;

public class UserInfo extends TeaModel {
    // userName
    @NameInMap("UserName")
    public String userName;

    // userAge
    @NameInMap("UserAge")
    public String userAge;

    // address
    @NameInMap("Address")
    public String address;

    public static UserInfo build(java.util.Map<String, ?> map) throws Exception {
        UserInfo self = new UserInfo();
        return TeaModel.build(map, self);
    }

    public UserInfo setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public UserInfo setUserAge(String userAge) {
        this.userAge = userAge;
        return this;
    }
    public String getUserAge() {
        return this.userAge;
    }

    public UserInfo setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

}
