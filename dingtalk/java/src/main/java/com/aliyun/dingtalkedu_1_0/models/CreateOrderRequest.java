// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateOrderRequest extends TeaModel {
    /**
     * <p>实付金额，单位分（优惠计算后）</p>
     */
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <p>开单时间</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>订单明细信息</p>
     */
    @NameInMap("detailList")
    public java.util.List<CreateOrderRequestDetailList> detailList;

    /**
     * <p>人脸id</p>
     */
    @NameInMap("faceId")
    public String faceId;

    /**
     * <p>刷脸token</p>
     */
    @NameInMap("ftoken")
    public String ftoken;

    /**
     * <p>签名</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>设备号</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>交易加签</p>
     */
    @NameInMap("terminalParams")
    public String terminalParams;

    /**
     * <p>utc时间戳</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    /**
     * <p>应付价格，单位分</p>
     */
    @NameInMap("totalAmount")
    public Long totalAmount;

    /**
     * <p>员工id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>版本号</p>
     */
    @NameInMap("version")
    public String version;

    public static CreateOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateOrderRequest self = new CreateOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreateOrderRequest setActualAmount(Long actualAmount) {
        this.actualAmount = actualAmount;
        return this;
    }
    public Long getActualAmount() {
        return this.actualAmount;
    }

    public CreateOrderRequest setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public CreateOrderRequest setDetailList(java.util.List<CreateOrderRequestDetailList> detailList) {
        this.detailList = detailList;
        return this;
    }
    public java.util.List<CreateOrderRequestDetailList> getDetailList() {
        return this.detailList;
    }

    public CreateOrderRequest setFaceId(String faceId) {
        this.faceId = faceId;
        return this;
    }
    public String getFaceId() {
        return this.faceId;
    }

    public CreateOrderRequest setFtoken(String ftoken) {
        this.ftoken = ftoken;
        return this;
    }
    public String getFtoken() {
        return this.ftoken;
    }

    public CreateOrderRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public CreateOrderRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public CreateOrderRequest setTerminalParams(String terminalParams) {
        this.terminalParams = terminalParams;
        return this;
    }
    public String getTerminalParams() {
        return this.terminalParams;
    }

    public CreateOrderRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public CreateOrderRequest setTotalAmount(Long totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public Long getTotalAmount() {
        return this.totalAmount;
    }

    public CreateOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateOrderRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

    public static class CreateOrderRequestDetailList extends TeaModel {
        /**
         * <p>计算优惠后的实付金额，单位为分</p>
         */
        @NameInMap("actualAmount")
        public Long actualAmount;

        /**
         * <p>应付金额，单位为分</p>
         */
        @NameInMap("itemAmount")
        public Long itemAmount;

        /**
         * <p>商品名</p>
         */
        @NameInMap("itemName")
        public String itemName;

        /**
         * <p>场景</p>
         */
        @NameInMap("scene")
        public Long scene;

        public static CreateOrderRequestDetailList build(java.util.Map<String, ?> map) throws Exception {
            CreateOrderRequestDetailList self = new CreateOrderRequestDetailList();
            return TeaModel.build(map, self);
        }

        public CreateOrderRequestDetailList setActualAmount(Long actualAmount) {
            this.actualAmount = actualAmount;
            return this;
        }
        public Long getActualAmount() {
            return this.actualAmount;
        }

        public CreateOrderRequestDetailList setItemAmount(Long itemAmount) {
            this.itemAmount = itemAmount;
            return this;
        }
        public Long getItemAmount() {
            return this.itemAmount;
        }

        public CreateOrderRequestDetailList setItemName(String itemName) {
            this.itemName = itemName;
            return this;
        }
        public String getItemName() {
            return this.itemName;
        }

        public CreateOrderRequestDetailList setScene(Long scene) {
            this.scene = scene;
            return this;
        }
        public Long getScene() {
            return this.scene;
        }

    }

}
