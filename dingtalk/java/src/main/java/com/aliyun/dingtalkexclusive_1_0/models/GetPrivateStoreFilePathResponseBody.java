// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFilePathResponseBody extends TeaModel {
    @NameInMap("filePath")
    public String filePath;

    public static GetPrivateStoreFilePathResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFilePathResponseBody self = new GetPrivateStoreFilePathResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFilePathResponseBody setFilePath(String filePath) {
        this.filePath = filePath;
        return this;
    }
    public String getFilePath() {
        return this.filePath;
    }

}
