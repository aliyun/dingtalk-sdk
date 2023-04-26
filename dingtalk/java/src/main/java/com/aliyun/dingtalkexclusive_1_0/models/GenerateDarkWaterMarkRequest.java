// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GenerateDarkWaterMarkRequest extends TeaModel {
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static GenerateDarkWaterMarkRequest build(java.util.Map<String, ?> map) throws Exception {
        GenerateDarkWaterMarkRequest self = new GenerateDarkWaterMarkRequest();
        return TeaModel.build(map, self);
    }

    public GenerateDarkWaterMarkRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
