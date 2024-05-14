// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUserInfoByOpenTokenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("docKey")
    public String docKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openToken")
    public String openToken;

    public static GetUserInfoByOpenTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserInfoByOpenTokenRequest self = new GetUserInfoByOpenTokenRequest();
        return TeaModel.build(map, self);
    }

    public GetUserInfoByOpenTokenRequest setDocKey(String docKey) {
        this.docKey = docKey;
        return this;
    }
    public String getDocKey() {
        return this.docKey;
    }

    public GetUserInfoByOpenTokenRequest setOpenToken(String openToken) {
        this.openToken = openToken;
        return this;
    }
    public String getOpenToken() {
        return this.openToken;
    }

}
