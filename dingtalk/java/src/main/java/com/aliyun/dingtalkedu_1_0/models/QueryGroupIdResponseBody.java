// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupIdResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("groupId")
    public String groupId;

    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("merchantName")
    public String merchantName;

    @NameInMap("name")
    public String name;

    @NameInMap("pid")
    public String pid;

    public static QueryGroupIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupIdResponseBody self = new QueryGroupIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupIdResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryGroupIdResponseBody setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

    public QueryGroupIdResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public QueryGroupIdResponseBody setMerchantName(String merchantName) {
        this.merchantName = merchantName;
        return this;
    }
    public String getMerchantName() {
        return this.merchantName;
    }

    public QueryGroupIdResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public QueryGroupIdResponseBody setPid(String pid) {
        this.pid = pid;
        return this;
    }
    public String getPid() {
        return this.pid;
    }

}
