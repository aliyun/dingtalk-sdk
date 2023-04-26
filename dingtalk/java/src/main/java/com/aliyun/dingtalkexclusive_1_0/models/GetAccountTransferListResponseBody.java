// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAccountTransferListResponseBody extends TeaModel {
    @NameInMap("itemList")
    public java.util.List<GetAccountTransferListResponseBodyItemList> itemList;

    @NameInMap("totalCount")
    public Long totalCount;

    public static GetAccountTransferListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAccountTransferListResponseBody self = new GetAccountTransferListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAccountTransferListResponseBody setItemList(java.util.List<GetAccountTransferListResponseBodyItemList> itemList) {
        this.itemList = itemList;
        return this;
    }
    public java.util.List<GetAccountTransferListResponseBodyItemList> getItemList() {
        return this.itemList;
    }

    public GetAccountTransferListResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetAccountTransferListResponseBodyItemList extends TeaModel {
        @NameInMap("deptName")
        public Long deptName;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static GetAccountTransferListResponseBodyItemList build(java.util.Map<String, ?> map) throws Exception {
            GetAccountTransferListResponseBodyItemList self = new GetAccountTransferListResponseBodyItemList();
            return TeaModel.build(map, self);
        }

        public GetAccountTransferListResponseBodyItemList setDeptName(Long deptName) {
            this.deptName = deptName;
            return this;
        }
        public Long getDeptName() {
            return this.deptName;
        }

        public GetAccountTransferListResponseBodyItemList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetAccountTransferListResponseBodyItemList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
