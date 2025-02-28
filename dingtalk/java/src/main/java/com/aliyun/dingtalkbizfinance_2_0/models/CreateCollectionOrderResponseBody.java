// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreateCollectionOrderResponseBody extends TeaModel {
    @NameInMap("collectionUrl")
    public String collectionUrl;

    public static CreateCollectionOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCollectionOrderResponseBody self = new CreateCollectionOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCollectionOrderResponseBody setCollectionUrl(String collectionUrl) {
        this.collectionUrl = collectionUrl;
        return this;
    }
    public String getCollectionUrl() {
        return this.collectionUrl;
    }

}
