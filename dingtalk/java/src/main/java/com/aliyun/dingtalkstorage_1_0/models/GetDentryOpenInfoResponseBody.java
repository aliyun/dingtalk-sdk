// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryOpenInfoResponseBody extends TeaModel {
    // 链接, 用于编辑或预览
    @NameInMap("url")
    public String url;

    public static GetDentryOpenInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDentryOpenInfoResponseBody self = new GetDentryOpenInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDentryOpenInfoResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
