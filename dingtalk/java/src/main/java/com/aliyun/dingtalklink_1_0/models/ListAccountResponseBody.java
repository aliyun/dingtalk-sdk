// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class ListAccountResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListAccountResponseBodyResult> result;

    public static ListAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAccountResponseBody self = new ListAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAccountResponseBody setResult(java.util.List<ListAccountResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListAccountResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListAccountResponseBodyResult extends TeaModel {
        @NameInMap("accountId")
        public String accountId;

        @NameInMap("accountName")
        public String accountName;

        public static ListAccountResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListAccountResponseBodyResult self = new ListAccountResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListAccountResponseBodyResult setAccountId(String accountId) {
            this.accountId = accountId;
            return this;
        }
        public String getAccountId() {
            return this.accountId;
        }

        public ListAccountResponseBodyResult setAccountName(String accountName) {
            this.accountName = accountName;
            return this;
        }
        public String getAccountName() {
            return this.accountName;
        }

    }

}
