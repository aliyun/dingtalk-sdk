// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class InfoSpaceRequest extends TeaModel {
    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static InfoSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        InfoSpaceRequest self = new InfoSpaceRequest();
        return TeaModel.build(map, self);
    }

    public InfoSpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
