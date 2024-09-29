// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class OrderInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public OrderInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static OrderInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OrderInfoResponseBody self = new OrderInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public OrderInfoResponseBody setResult(OrderInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public OrderInfoResponseBodyResult getResult() {
        return this.result;
    }

    public OrderInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class OrderInfoResponseBodyResultItemList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>商品名称</p>
         */
        @NameInMap("itemName")
        public String itemName;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("itemNum")
        public String itemNum;

        public static OrderInfoResponseBodyResultItemList build(java.util.Map<String, ?> map) throws Exception {
            OrderInfoResponseBodyResultItemList self = new OrderInfoResponseBodyResultItemList();
            return TeaModel.build(map, self);
        }

        public OrderInfoResponseBodyResultItemList setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

        public OrderInfoResponseBodyResultItemList setItemNum(String itemNum) {
            this.itemNum = itemNum;
            return this;
        }
        public String getItemNum() {
            return this.itemNum;
        }

    }

    public static class OrderInfoResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxx店铺</p>
         */
        @NameInMap("address")
        public String address;

        @NameInMap("itemList")
        public java.util.List<OrderInfoResponseBodyResultItemList> itemList;

        /**
         * <strong>example:</strong>
         * <p>808324521</p>
         */
        @NameInMap("orderNo")
        public String orderNo;

        /**
         * <strong>example:</strong>
         * <p>7245</p>
         */
        @NameInMap("receiverPhoneSuffix")
        public String receiverPhoneSuffix;

        /**
         * <strong>example:</strong>
         * <p>商家名称</p>
         */
        @NameInMap("shopName")
        public String shopName;

        @NameInMap("userId")
        public Long userId;

        public static OrderInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            OrderInfoResponseBodyResult self = new OrderInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public OrderInfoResponseBodyResult setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public OrderInfoResponseBodyResult setItemList(java.util.List<OrderInfoResponseBodyResultItemList> itemList) {
            this.itemList = itemList;
            return this;
        }
        public java.util.List<OrderInfoResponseBodyResultItemList> getItemList() {
            return this.itemList;
        }

        public OrderInfoResponseBodyResult setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public OrderInfoResponseBodyResult setReceiverPhoneSuffix(String receiverPhoneSuffix) {
            this.receiverPhoneSuffix = receiverPhoneSuffix;
            return this;
        }
        public String getReceiverPhoneSuffix() {
            return this.receiverPhoneSuffix;
        }

        public OrderInfoResponseBodyResult setShopName(String shopName) {
            this.shopName = shopName;
            return this;
        }
        public String getShopName() {
            return this.shopName;
        }

        public OrderInfoResponseBodyResult setUserId(Long userId) {
            this.userId = userId;
            return this;
        }
        public Long getUserId() {
            return this.userId;
        }

    }

}
