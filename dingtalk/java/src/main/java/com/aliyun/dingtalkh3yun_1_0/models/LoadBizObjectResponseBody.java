// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizObjectResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 返回结果
    @NameInMap("data")
    public java.util.Map<String, ?> data;

    // 提示信息
    @NameInMap("message")
    public String message;

    public static LoadBizObjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LoadBizObjectResponseBody self = new LoadBizObjectResponseBody();
        return TeaModel.build(map, self);
    }

    public LoadBizObjectResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public LoadBizObjectResponseBody setData(java.util.Map<String, ?> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, ?> getData() {
        return this.data;
    }

    public LoadBizObjectResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
