// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocUpdateContentWithDelegatedPermissionResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.Map<String, ?> data;

    public static DocUpdateContentWithDelegatedPermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocUpdateContentWithDelegatedPermissionResponseBody self = new DocUpdateContentWithDelegatedPermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public DocUpdateContentWithDelegatedPermissionResponseBody setData(java.util.Map<String, ?> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, ?> getData() {
        return this.data;
    }

}
