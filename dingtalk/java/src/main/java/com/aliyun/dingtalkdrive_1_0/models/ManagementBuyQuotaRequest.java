// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ManagementBuyQuotaRequest extends TeaModel {
    // token
    @NameInMap("token")
    public String token;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    // 订单
    @NameInMap("order")
    public ManagementBuyQuotaRequestOrder order;

    public static ManagementBuyQuotaRequest build(java.util.Map<String, ?> map) throws Exception {
        ManagementBuyQuotaRequest self = new ManagementBuyQuotaRequest();
        return TeaModel.build(map, self);
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

    public ManagementBuyQuotaRequest setOrder(ManagementBuyQuotaRequestOrder order) {
        this.order = order;
        return this;
    }
    public ManagementBuyQuotaRequestOrder getOrder() {
        return this.order;
    }

    public static class ManagementBuyQuotaRequestOrder extends TeaModel {
        // 订单id
        @NameInMap("orderId")
        public Long orderId;

        // 业务类型
        @NameInMap("bizType")
        public String bizType;

        // 容量类型
        @NameInMap("capacityType")
        public String capacityType;

        // 待扩容的容量
        @NameInMap("capacity")
        public Long capacity;

        // 时长
        @NameInMap("day")
        public Integer day;

        // 金额
        @NameInMap("money")
        public Long money;

        public static ManagementBuyQuotaRequestOrder build(java.util.Map<String, ?> map) throws Exception {
            ManagementBuyQuotaRequestOrder self = new ManagementBuyQuotaRequestOrder();
            return TeaModel.build(map, self);
        }

        public ManagementBuyQuotaRequestOrder setOrderId(Long orderId) {
            this.orderId = orderId;
            return this;
        }
        public Long getOrderId() {
            return this.orderId;
        }

        public ManagementBuyQuotaRequestOrder setBizType(String bizType) {
            this.bizType = bizType;
            return this;
        }
        public String getBizType() {
            return this.bizType;
        }

        public ManagementBuyQuotaRequestOrder setCapacityType(String capacityType) {
            this.capacityType = capacityType;
            return this;
        }
        public String getCapacityType() {
            return this.capacityType;
        }

        public ManagementBuyQuotaRequestOrder setCapacity(Long capacity) {
            this.capacity = capacity;
            return this;
        }
        public Long getCapacity() {
            return this.capacity;
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

    }

}
