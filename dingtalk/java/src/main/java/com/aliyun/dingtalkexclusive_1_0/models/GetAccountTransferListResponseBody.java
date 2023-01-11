// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAccountTransferListResponseBody extends TeaModel {
    /**
     * <p>迁移详情数据</p>
     */
    @NameInMap("itemList")
    public java.util.List<GetAccountTransferListResponseBodyItemList> itemList;

    /**
     * <p>总数据量</p>
     */
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
        /**
         * <p>部门名称</p>
         */
        @NameInMap("deptName")
        public Long deptName;

        /**
         * <p>员工名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>工号</p>
         */
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
