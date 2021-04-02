// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbProjectSourceResponseBody extends TeaModel {
    // 应用安装来源，"0"：来自应用中心，”6“：预安装
    @NameInMap("installSource")
    public String installSource;

    public static GetTbProjectSourceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTbProjectSourceResponseBody self = new GetTbProjectSourceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTbProjectSourceResponseBody setInstallSource(String installSource) {
        this.installSource = installSource;
        return this;
    }
    public String getInstallSource() {
        return this.installSource;
    }

}
