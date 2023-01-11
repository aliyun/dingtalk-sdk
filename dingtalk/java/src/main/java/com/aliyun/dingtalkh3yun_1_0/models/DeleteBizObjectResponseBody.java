// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class DeleteBizObjectResponseBody extends TeaModel {
    /**
     * <p>状态码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>提示信息</p>
     */
    @NameInMap("message")
    public String message;

    public static DeleteBizObjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteBizObjectResponseBody self = new DeleteBizObjectResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteBizObjectResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public DeleteBizObjectResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
