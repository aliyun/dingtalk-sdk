// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class Recipient extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="mailto:zhangsan@b.com">zhangsan@b.com</a></p>
     */
    @NameInMap("email")
    public java.io.InputStream email;

    /**
     * <strong>example:</strong>
     * <p>ZhangSan</p>
     */
    @NameInMap("name")
    public java.io.InputStream name;

    public static Recipient build(java.util.Map<String, ?> map) throws Exception {
        Recipient self = new Recipient();
        return TeaModel.build(map, self);
    }

    public Recipient setEmail(java.io.InputStream email) {
        this.email = email;
        return this;
    }
    public java.io.InputStream getEmail() {
        return this.email;
    }

    public Recipient setName(java.io.InputStream name) {
        this.name = name;
        return this;
    }
    public java.io.InputStream getName() {
        return this.name;
    }

}
