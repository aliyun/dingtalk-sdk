// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetSaleUserInfoByUserIdResponseBody extends TeaModel {
    // userName
    @NameInMap("userName")
    public String userName;

    // userId
    @NameInMap("userId")
    public String userId;

    // accountId
    @NameInMap("accountId")
    public Long accountId;

    // corpList
    @NameInMap("corpList")
    public java.util.List<GetSaleUserInfoByUserIdResponseBodyCorpList> corpList;

    public static GetSaleUserInfoByUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSaleUserInfoByUserIdResponseBody self = new GetSaleUserInfoByUserIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSaleUserInfoByUserIdResponseBody setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public GetSaleUserInfoByUserIdResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetSaleUserInfoByUserIdResponseBody setAccountId(Long accountId) {
        this.accountId = accountId;
        return this;
    }
    public Long getAccountId() {
        return this.accountId;
    }

    public GetSaleUserInfoByUserIdResponseBody setCorpList(java.util.List<GetSaleUserInfoByUserIdResponseBodyCorpList> corpList) {
        this.corpList = corpList;
        return this;
    }
    public java.util.List<GetSaleUserInfoByUserIdResponseBodyCorpList> getCorpList() {
        return this.corpList;
    }

    public static class GetSaleUserInfoByUserIdResponseBodyCorpList extends TeaModel {
        // namespace
        @NameInMap("namespace")
        public String namespace;

        // corpId
        @NameInMap("corpId")
        public String corpId;

        // corpName
        @NameInMap("corpName")
        public String corpName;

        public static GetSaleUserInfoByUserIdResponseBodyCorpList build(java.util.Map<String, ?> map) throws Exception {
            GetSaleUserInfoByUserIdResponseBodyCorpList self = new GetSaleUserInfoByUserIdResponseBodyCorpList();
            return TeaModel.build(map, self);
        }

        public GetSaleUserInfoByUserIdResponseBodyCorpList setNamespace(String namespace) {
            this.namespace = namespace;
            return this;
        }
        public String getNamespace() {
            return this.namespace;
        }

        public GetSaleUserInfoByUserIdResponseBodyCorpList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetSaleUserInfoByUserIdResponseBodyCorpList setCorpName(String corpName) {
            this.corpName = corpName;
            return this;
        }
        public String getCorpName() {
            return this.corpName;
        }

    }

}
