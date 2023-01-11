// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementBuyQuotaRequest extends TeaModel {
    /**
     * <p>订单</p>
     */
    @NameInMap("order")
    public ManagementBuyQuotaRequestOrder order;

    /**
     * <p>token</p>
     */
    @NameInMap("token")
    public String token;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ManagementBuyQuotaRequest build(java.util.Map<String, ?> map) throws Exception {
        ManagementBuyQuotaRequest self = new ManagementBuyQuotaRequest();
        return TeaModel.build(map, self);
    }

    public ManagementBuyQuotaRequest setOrder(ManagementBuyQuotaRequestOrder order) {
        this.order = order;
        return this;
    }
    public ManagementBuyQuotaRequestOrder getOrder() {
        return this.order;
    }

    public ManagementBuyQuotaRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public ManagementBuyQuotaRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class ManagementBuyQuotaRequestOrder extends TeaModel {
        /**
         * <p>业务类型</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>待扩容的容量</p>
         */
        @NameInMap("capacity")
        public Long capacity;

        /**
         * <p>容量类型</p>
         */
        @NameInMap("capacityType")
        public String capacityType;

        /**
         * <p>时长</p>
         */
        @NameInMap("day")
        public Integer day;

        /**
         * <p>金额</p>
         */
        @NameInMap("money")
        public Long money;

        /**
         * <p>订单id</p>
         */
        @NameInMap("orderId")
        public Long orderId;

        public static ManagementBuyQuotaRequestOrder build(java.util.Map<String, ?> map) throws Exception {
            ManagementBuyQuotaRequestOrder self = new ManagementBuyQuotaRequestOrder();
            return TeaModel.build(map, self);
        }

        public ManagementBuyQuotaRequestOrder setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public ManagementBuyQuotaRequestOrder setCapacity(Long capacity) {
            this.capacity = capacity;
            return this;
        }
        public Long getCapacity() {
            return this.capacity;
        }

        public ManagementBuyQuotaRequestOrder setCapacityType(String capacityType) {
            this.capacityType = capacityType;
            return this;
        }
        public String getCapacityType() {
            return this.capacityType;
        }

        public ManagementBuyQuotaRequestOrder setDay(Integer day) {
            this.day = day;
            return this;
        }
        public Integer getDay() {
            return this.day;
        }

        public ManagementBuyQuotaRequestOrder setMoney(Long money) {
            this.money = money;
            return this;
        }
        public Long getMoney() {
            return this.money;
        }

        public ManagementBuyQuotaRequestOrder setOrderId(Long orderId) {
            this.orderId = orderId;
            return this;
        }
        public Long getOrderId() {
            return this.orderId;
        }

    }

}
