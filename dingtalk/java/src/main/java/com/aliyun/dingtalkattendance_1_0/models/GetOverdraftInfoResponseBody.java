// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetOverdraftInfoResponseBody extends TeaModel {
    @NameInMap("overdraftList")
    public java.util.List<GetOverdraftInfoResponseBodyOverdraftList> overdraftList;

    public static GetOverdraftInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOverdraftInfoResponseBody self = new GetOverdraftInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOverdraftInfoResponseBody setOverdraftList(java.util.List<GetOverdraftInfoResponseBodyOverdraftList> overdraftList) {
        this.overdraftList = overdraftList;
        return this;
    }
    public java.util.List<GetOverdraftInfoResponseBodyOverdraftList> getOverdraftList() {
        return this.overdraftList;
    }

    public static class GetOverdraftInfoResponseBodyOverdraftList extends TeaModel {
        @NameInMap("overdraft")
        public Integer overdraft;

        @NameInMap("unit")
        public String unit;

        @NameInMap("userId")
        public String userId;

        public static GetOverdraftInfoResponseBodyOverdraftList build(java.util.Map<String, ?> map) throws Exception {
            GetOverdraftInfoResponseBodyOverdraftList self = new GetOverdraftInfoResponseBodyOverdraftList();
            return TeaModel.build(map, self);
        }

        public GetOverdraftInfoResponseBodyOverdraftList setOverdraft(Integer overdraft) {
            this.overdraft = overdraft;
            return this;
        }
        public Integer getOverdraft() {
            return this.overdraft;
        }

        public GetOverdraftInfoResponseBodyOverdraftList setUnit(String unit) {
            this.unit = unit;
            return this;
        }
        public String getUnit() {
            return this.unit;
        }

        public GetOverdraftInfoResponseBodyOverdraftList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
