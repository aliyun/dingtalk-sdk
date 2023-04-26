// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserStayLengthResponseBody extends TeaModel {
    @NameInMap("itemList")
    public java.util.List<GetUserStayLengthResponseBodyItemList> itemList;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetUserStayLengthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserStayLengthResponseBody self = new GetUserStayLengthResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserStayLengthResponseBody setItemList(java.util.List<GetUserStayLengthResponseBodyItemList> itemList) {
        this.itemList = itemList;
        return this;
    }
    public java.util.List<GetUserStayLengthResponseBodyItemList> getItemList() {
        return this.itemList;
    }

    public GetUserStayLengthResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetUserStayLengthResponseBodyItemList extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("statDate")
        public String statDate;

        @NameInMap("stayTimeLenApp1d")
        public Long stayTimeLenApp1d;

        @NameInMap("stayTimeLenPc1d")
        public Long stayTimeLenPc1d;

        @NameInMap("userId")
        public String userId;

        public static GetUserStayLengthResponseBodyItemList build(java.util.Map<String, ?> map) throws Exception {
            GetUserStayLengthResponseBodyItemList self = new GetUserStayLengthResponseBodyItemList();
            return TeaModel.build(map, self);
        }

        public GetUserStayLengthResponseBodyItemList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetUserStayLengthResponseBodyItemList setStatDate(String statDate) {
            this.statDate = statDate;
            return this;
        }
        public String getStatDate() {
            return this.statDate;
        }

        public GetUserStayLengthResponseBodyItemList setStayTimeLenApp1d(Long stayTimeLenApp1d) {
            this.stayTimeLenApp1d = stayTimeLenApp1d;
            return this;
        }
        public Long getStayTimeLenApp1d() {
            return this.stayTimeLenApp1d;
        }

        public GetUserStayLengthResponseBodyItemList setStayTimeLenPc1d(Long stayTimeLenPc1d) {
            this.stayTimeLenPc1d = stayTimeLenPc1d;
            return this;
        }
        public Long getStayTimeLenPc1d() {
            return this.stayTimeLenPc1d;
        }

        public GetUserStayLengthResponseBodyItemList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
