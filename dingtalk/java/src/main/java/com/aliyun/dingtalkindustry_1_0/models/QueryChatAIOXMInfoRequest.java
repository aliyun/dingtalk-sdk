// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryChatAIOXMInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>专属AI 平台信息Code</p>
     */
    @NameInMap("code")
    public String code;

    public static QueryChatAIOXMInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryChatAIOXMInfoRequest self = new QueryChatAIOXMInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryChatAIOXMInfoRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
