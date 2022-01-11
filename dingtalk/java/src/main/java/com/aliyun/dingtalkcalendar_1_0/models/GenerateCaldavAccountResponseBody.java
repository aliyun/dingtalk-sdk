// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GenerateCaldavAccountResponseBody extends TeaModel {
    @NameInMap("password")
    public String password;

    @NameInMap("serverAddress")
    public String serverAddress;

    @NameInMap("username")
    public String username;

    public static GenerateCaldavAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GenerateCaldavAccountResponseBody self = new GenerateCaldavAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public GenerateCaldavAccountResponseBody setPassword(String password) {
        this.password = password;
        return this;
    }
    public String getPassword() {
        return this.password;
    }

    public GenerateCaldavAccountResponseBody setServerAddress(String serverAddress) {
        this.serverAddress = serverAddress;
        return this;
    }
    public String getServerAddress() {
        return this.serverAddress;
    }

    public GenerateCaldavAccountResponseBody setUsername(String username) {
        this.username = username;
        return this;
    }
    public String getUsername() {
        return this.username;
    }

}
