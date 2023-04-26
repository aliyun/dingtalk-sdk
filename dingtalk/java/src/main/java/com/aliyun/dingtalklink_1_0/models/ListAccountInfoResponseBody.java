// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListAccountInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListAccountInfoResponseBodyResult> result;

    public static ListAccountInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAccountInfoResponseBody self = new ListAccountInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAccountInfoResponseBody setResult(java.util.List<ListAccountInfoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListAccountInfoResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListAccountInfoResponseBodyResult extends TeaModel {
        @NameInMap("accountId")
        public String accountId;

        @NameInMap("accountName")
        public String accountName;

        public static ListAccountInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListAccountInfoResponseBodyResult self = new ListAccountInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListAccountInfoResponseBodyResult setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public ListAccountInfoResponseBodyResult setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

    }

}
