// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class ConvertUnionIdRequest extends TeaModel {
    @NameInMap("unionIdList")
    public java.util.List<String> unionIdList;

    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static ConvertUnionIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ConvertUnionIdRequest self = new ConvertUnionIdRequest();
        return TeaModel.build(map, self);
    }

    public ConvertUnionIdRequest setUnionIdList(java.util.List<String> unionIdList) {
        this.unionIdList = unionIdList;
        return this;
    }
    public java.util.List<String> getUnionIdList() {
        return this.unionIdList;
    }

    public ConvertUnionIdRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
