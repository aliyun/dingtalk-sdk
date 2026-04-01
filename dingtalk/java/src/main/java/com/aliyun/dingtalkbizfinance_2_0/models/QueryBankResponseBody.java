// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryBankResponseBody extends TeaModel {
    @NameInMap("supportBanks")
    public java.util.List<QueryBankResponseBodySupportBanks> supportBanks;

    public static QueryBankResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryBankResponseBody self = new QueryBankResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryBankResponseBody setSupportBanks(java.util.List<QueryBankResponseBodySupportBanks> supportBanks) {
        this.supportBanks = supportBanks;
        return this;
    }
    public java.util.List<QueryBankResponseBodySupportBanks> getSupportBanks() {
        return this.supportBanks;
    }

    public static class QueryBankResponseBodySupportBanks extends TeaModel {
        @NameInMap("bankAbbr")
        public String bankAbbr;

        @NameInMap("bankFirstPinYin")
        public String bankFirstPinYin;

        @NameInMap("bankName")
        public String bankName;

        public static QueryBankResponseBodySupportBanks build(java.util.Map<String, ?> map) throws Exception {
            QueryBankResponseBodySupportBanks self = new QueryBankResponseBodySupportBanks();
            return TeaModel.build(map, self);
        }

        public QueryBankResponseBodySupportBanks setBankAbbr(String bankAbbr) {
            this.bankAbbr = bankAbbr;
            return this;
        }
        public String getBankAbbr() {
            return this.bankAbbr;
        }

        public QueryBankResponseBodySupportBanks setBankFirstPinYin(String bankFirstPinYin) {
            this.bankFirstPinYin = bankFirstPinYin;
            return this;
        }
        public String getBankFirstPinYin() {
            return this.bankFirstPinYin;
        }

        public QueryBankResponseBodySupportBanks setBankName(String bankName) {
            this.bankName = bankName;
            return this;
        }
        public String getBankName() {
            return this.bankName;
        }

    }

}
