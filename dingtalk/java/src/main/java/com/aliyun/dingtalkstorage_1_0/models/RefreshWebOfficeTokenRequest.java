// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RefreshWebOfficeTokenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("webOfficeAccessToken")
    public String webOfficeAccessToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("webOfficeRefreshToken")
    public String webOfficeRefreshToken;

    public static RefreshWebOfficeTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        RefreshWebOfficeTokenRequest self = new RefreshWebOfficeTokenRequest();
        return TeaModel.build(map, self);
    }

    public RefreshWebOfficeTokenRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public RefreshWebOfficeTokenRequest setWebOfficeAccessToken(String webOfficeAccessToken) {
        this.webOfficeAccessToken = webOfficeAccessToken;
        return this;
    }
    public String getWebOfficeAccessToken() {
        return this.webOfficeAccessToken;
    }

    public RefreshWebOfficeTokenRequest setWebOfficeRefreshToken(String webOfficeRefreshToken) {
        this.webOfficeRefreshToken = webOfficeRefreshToken;
        return this;
    }
    public String getWebOfficeRefreshToken() {
        return this.webOfficeRefreshToken;
    }

}
