// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryOpenInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasWaterMark")
    public Boolean hasWaterMark;

    /**
     * <strong>example:</strong>
     * <p>url</p>
     */
    @NameInMap("url")
    public String url;

    public static GetDentryOpenInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDentryOpenInfoResponseBody self = new GetDentryOpenInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDentryOpenInfoResponseBody setHasWaterMark(Boolean hasWaterMark) {
        this.hasWaterMark = hasWaterMark;
        return this;
    }
    public Boolean getHasWaterMark() {
        return this.hasWaterMark;
    }

    public GetDentryOpenInfoResponseBody setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

}
