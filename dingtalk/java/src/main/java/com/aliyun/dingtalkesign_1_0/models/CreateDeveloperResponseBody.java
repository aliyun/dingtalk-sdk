// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class CreateDeveloperResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public Boolean data;

    @NameInMap("message")
    public String message;

    public static CreateDeveloperResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDeveloperResponseBody self = new CreateDeveloperResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDeveloperResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public CreateDeveloperResponseBody setData(Boolean data) {
        this.data = data;
        return this;
    }
    public Boolean getData() {
        return this.data;
    }

    public CreateDeveloperResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
