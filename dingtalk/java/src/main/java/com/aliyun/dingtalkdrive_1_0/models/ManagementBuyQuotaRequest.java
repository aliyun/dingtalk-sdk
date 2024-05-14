// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementBuyQuotaRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("order")
    public ManagementBuyQuotaRequestOrder order;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("token")
    public String token;

    /**
     * <p>This parameter is required.</p>
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("bizType")
        public String bizType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("capacity")
        public Long capacity;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("capacityType")
        public String capacityType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("day")
        public Integer day;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("money")
        public Long money;

        /**
         * <p>This parameter is required.</p>
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
