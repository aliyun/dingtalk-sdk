// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetCorpConsoleResponseBody extends TeaModel {
    @NameInMap("orgConsoleUrl")
    public String orgConsoleUrl;

    public static GetCorpConsoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpConsoleResponseBody self = new GetCorpConsoleResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpConsoleResponseBody setOrgConsoleUrl(String orgConsoleUrl) {
        this.orgConsoleUrl = orgConsoleUrl;
        return this;
    }
    public String getOrgConsoleUrl() {
        return this.orgConsoleUrl;
    }

}
