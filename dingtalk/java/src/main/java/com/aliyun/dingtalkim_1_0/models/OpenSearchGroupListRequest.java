// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class OpenSearchGroupListRequest extends TeaModel {
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static OpenSearchGroupListRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenSearchGroupListRequest self = new OpenSearchGroupListRequest();
        return TeaModel.build(map, self);
    }

    public OpenSearchGroupListRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public OpenSearchGroupListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
