// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayOrgGetResponseBody extends TeaModel {
    // 灰度组织corpId列表
    @NameInMap("value")
    public java.util.List<String> value;

    public static ReleaseGrayOrgGetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayOrgGetResponseBody self = new ReleaseGrayOrgGetResponseBody();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayOrgGetResponseBody setValue(java.util.List<String> value) {
        this.value = value;
        return this;
    }
    public java.util.List<String> getValue() {
        return this.value;
    }

}
