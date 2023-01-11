// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetSaleUserInfoByUserIdResponseBody extends TeaModel {
    /**
     * <p>accountId</p>
     */
    @NameInMap("accountId")
    public Long accountId;

    /**
     * <p>corpList</p>
     */
    @NameInMap("corpList")
    public java.util.List<GetSaleUserInfoByUserIdResponseBodyCorpList> corpList;

    /**
     * <p>userId</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>userName</p>
     */
    @NameInMap("userName")
    public String userName;

    public static GetSaleUserInfoByUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSaleUserInfoByUserIdResponseBody self = new GetSaleUserInfoByUserIdResponseBody();
        return TeaModel.build(map, self);
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

    public GetSaleUserInfoByUserIdResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetSaleUserInfoByUserIdResponseBody setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public static class GetSaleUserInfoByUserIdResponseBodyCorpList extends TeaModel {
        /**
         * <p>corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>corpName</p>
         */
        @NameInMap("corpName")
        public String corpName;

        /**
         * <p>namespace</p>
         */
        @NameInMap("namespace")
        public String namespace;

        public static GetSaleUserInfoByUserIdResponseBodyCorpList build(java.util.Map<String, ?> map) throws Exception {
            GetSaleUserInfoByUserIdResponseBodyCorpList self = new GetSaleUserInfoByUserIdResponseBodyCorpList();
            return TeaModel.build(map, self);
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

        public GetSaleUserInfoByUserIdResponseBodyCorpList setNamespace(String namespace) {
            this.namespace = namespace;
            return this;
        }
        public String getNamespace() {
            return this.namespace;
        }

    }

}
