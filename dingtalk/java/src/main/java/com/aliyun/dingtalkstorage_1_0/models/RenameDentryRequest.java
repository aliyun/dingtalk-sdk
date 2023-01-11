// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RenameDentryRequest extends TeaModel {
    /**
     * <p>名称(文件名+后缀), 规则：</p>
     * <p>1. 头尾不能包含空格，否则会自动去除</p>
     * <p>2. 不能包含特殊字符，包括：制表符、*、"、<、>、|</p>
     * <p>3. 不能以"."结尾</p>
     */
    @NameInMap("newName")
    public String newName;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static RenameDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        RenameDentryRequest self = new RenameDentryRequest();
        return TeaModel.build(map, self);
    }

    public RenameDentryRequest setNewName(String newName) {
        this.newName = newName;
        return this;
    }
    public String getNewName() {
        return this.newName;
    }

    public RenameDentryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
