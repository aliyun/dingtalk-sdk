// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("actualAmount")
    public Long actualAmount;

    /**
     * <strong>example:</strong>
     * <p>1644413947909</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("detailList")
    public java.util.List<CreateOrderRequestDetailList> detailList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123123</p>
     */
    @NameInMap("faceId")
    public String faceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FACE_010100b0555Xczd4ePVLaB5V3cCzrONYpHWOENzRxDDqcnVjYXLso0U_1642665071746</p>
     */
    @NameInMap("ftoken")
    public String ftoken;

    /**
     * <strong>example:</strong>
     * <p>KSwZiSL1O7DiUNwjV168j3cP9ktp4bJTi5OQxAXre26KyBXza7+gCl/g1d0K3n3+9JhMqc2fUjBiENcAELw3Jb5xO/zslOeV4qFoMQfzW51+sdL/SSZCYvXEMhu9P6FAPhGZQ3vu6gr3oxUAXPIpWNb+sIfzR9epumoOXYeofH8=</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>QA62021121908E</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;terminalType&quot;:&quot;IOT&quot;}</p>
     */
    @NameInMap("terminalParams")
    public String terminalParams;

    /**
     * <strong>example:</strong>
     * <p>1644413947909</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalAmount")
    public Long totalAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1643334234626</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <strong>example:</strong>
     * <p>1.0</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("actualAmount")
        public Long actualAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("itemAmount")
        public Long itemAmount;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>测试商品</p>
         */
        @NameInMap("itemName")
        public String itemName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
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
