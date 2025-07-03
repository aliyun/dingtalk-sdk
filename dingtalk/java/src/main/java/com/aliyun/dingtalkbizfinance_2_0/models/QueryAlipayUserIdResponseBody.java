// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryAlipayUserIdResponseBody extends TeaModel {
    @NameInMap("alipayBizUserList")
    public java.util.List<QueryAlipayUserIdResponseBodyAlipayBizUserList> alipayBizUserList;

    public static QueryAlipayUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAlipayUserIdResponseBody self = new QueryAlipayUserIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAlipayUserIdResponseBody setAlipayBizUserList(java.util.List<QueryAlipayUserIdResponseBodyAlipayBizUserList> alipayBizUserList) {
        this.alipayBizUserList = alipayBizUserList;
        return this;
    }
    public java.util.List<QueryAlipayUserIdResponseBodyAlipayBizUserList> getAlipayBizUserList() {
        return this.alipayBizUserList;
    }

    public static class QueryAlipayUserIdResponseBodyAlipayBizUserList extends TeaModel {
        @NameInMap("alipayUserId")
        public String alipayUserId;

        @NameInMap("dingUserId")
        public String dingUserId;

        public static QueryAlipayUserIdResponseBodyAlipayBizUserList build(java.util.Map<String, ?> map) throws Exception {
            QueryAlipayUserIdResponseBodyAlipayBizUserList self = new QueryAlipayUserIdResponseBodyAlipayBizUserList();
            return TeaModel.build(map, self);
        }

        public QueryAlipayUserIdResponseBodyAlipayBizUserList setAlipayUserId(String alipayUserId) {
            this.alipayUserId = alipayUserId;
            return this;
        }
        public String getAlipayUserId() {
            return this.alipayUserId;
        }

        public QueryAlipayUserIdResponseBodyAlipayBizUserList setDingUserId(String dingUserId) {
            this.dingUserId = dingUserId;
            return this;
        }
        public String getDingUserId() {
            return this.dingUserId;
        }

    }

}
