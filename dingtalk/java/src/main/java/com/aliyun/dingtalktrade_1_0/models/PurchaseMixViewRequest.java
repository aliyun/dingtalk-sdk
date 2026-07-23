// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class PurchaseMixViewRequest extends TeaModel {
    @NameInMap("channelCode")
    public String channelCode;

    @NameInMap("combineActivityId")
    public Long combineActivityId;

    @NameInMap("createOrder")
    public Boolean createOrder;

    @NameInMap("list")
    public java.util.List<PurchaseMixViewRequestList> list;

    @NameInMap("memo")
    public String memo;

    @NameInMap("mergeOrderName")
    public String mergeOrderName;

    @NameInMap("needModelTypeList")
    public java.util.List<String> needModelTypeList;

    @NameInMap("objId")
    public Long objId;

    @NameInMap("objType")
    public Long objType;

    @NameInMap("orderParamMap")
    public java.util.Map<String, ?> orderParamMap;

    @NameInMap("outerTradeCode")
    public String outerTradeCode;

    @NameInMap("outerTradeType")
    public String outerTradeType;

    @NameInMap("planId")
    public Long planId;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("uid")
    public Long uid;

    @NameInMap("unPay")
    public Boolean unPay;

    public static PurchaseMixViewRequest build(java.util.Map<String, ?> map) throws Exception {
        PurchaseMixViewRequest self = new PurchaseMixViewRequest();
        return TeaModel.build(map, self);
    }

    public PurchaseMixViewRequest setChannelCode(String channelCode) {
        this.channelCode = channelCode;
        return this;
    }
    public String getChannelCode() {
        return this.channelCode;
    }

    public PurchaseMixViewRequest setCombineActivityId(Long combineActivityId) {
        this.combineActivityId = combineActivityId;
        return this;
    }
    public Long getCombineActivityId() {
        return this.combineActivityId;
    }

    public PurchaseMixViewRequest setCreateOrder(Boolean createOrder) {
        this.createOrder = createOrder;
        return this;
    }
    public Boolean getCreateOrder() {
        return this.createOrder;
    }

    public PurchaseMixViewRequest setList(java.util.List<PurchaseMixViewRequestList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<PurchaseMixViewRequestList> getList() {
        return this.list;
    }

    public PurchaseMixViewRequest setMemo(String memo) {
        this.memo = memo;
        return this;
    }
    public String getMemo() {
        return this.memo;
    }

    public PurchaseMixViewRequest setMergeOrderName(String mergeOrderName) {
        this.mergeOrderName = mergeOrderName;
        return this;
    }
    public String getMergeOrderName() {
        return this.mergeOrderName;
    }

    public PurchaseMixViewRequest setNeedModelTypeList(java.util.List<String> needModelTypeList) {
        this.needModelTypeList = needModelTypeList;
        return this;
    }
    public java.util.List<String> getNeedModelTypeList() {
        return this.needModelTypeList;
    }

    public PurchaseMixViewRequest setObjId(Long objId) {
        this.objId = objId;
        return this;
    }
    public Long getObjId() {
        return this.objId;
    }

    public PurchaseMixViewRequest setObjType(Long objType) {
        this.objType = objType;
        return this;
    }
    public Long getObjType() {
        return this.objType;
    }

    public PurchaseMixViewRequest setOrderParamMap(java.util.Map<String, ?> orderParamMap) {
        this.orderParamMap = orderParamMap;
        return this;
    }
    public java.util.Map<String, ?> getOrderParamMap() {
        return this.orderParamMap;
    }

    public PurchaseMixViewRequest setOuterTradeCode(String outerTradeCode) {
        this.outerTradeCode = outerTradeCode;
        return this;
    }
    public String getOuterTradeCode() {
        return this.outerTradeCode;
    }

    public PurchaseMixViewRequest setOuterTradeType(String outerTradeType) {
        this.outerTradeType = outerTradeType;
        return this;
    }
    public String getOuterTradeType() {
        return this.outerTradeType;
    }

    public PurchaseMixViewRequest setPlanId(Long planId) {
        this.planId = planId;
        return this;
    }
    public Long getPlanId() {
        return this.planId;
    }

    public PurchaseMixViewRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public PurchaseMixViewRequest setUid(Long uid) {
        this.uid = uid;
        return this;
    }
    public Long getUid() {
        return this.uid;
    }

    public PurchaseMixViewRequest setUnPay(Boolean unPay) {
        this.unPay = unPay;
        return this;
    }
    public Boolean getUnPay() {
        return this.unPay;
    }

    public static class PurchaseMixViewRequestListItemComponentListItemPropertyList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static PurchaseMixViewRequestListItemComponentListItemPropertyList build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewRequestListItemComponentListItemPropertyList self = new PurchaseMixViewRequestListItemComponentListItemPropertyList();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewRequestListItemComponentListItemPropertyList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public PurchaseMixViewRequestListItemComponentListItemPropertyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PurchaseMixViewRequestListItemComponentListItemPropertyList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class PurchaseMixViewRequestListItemComponentList extends TeaModel {
        @NameInMap("componentCode")
        public String componentCode;

        @NameInMap("componentName")
        public String componentName;

        @NameInMap("itemPropertyList")
        public java.util.List<PurchaseMixViewRequestListItemComponentListItemPropertyList> itemPropertyList;

        public static PurchaseMixViewRequestListItemComponentList build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewRequestListItemComponentList self = new PurchaseMixViewRequestListItemComponentList();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewRequestListItemComponentList setComponentCode(String componentCode) {
            this.componentCode = componentCode;
            return this;
        }
        public String getComponentCode() {
            return this.componentCode;
        }

        public PurchaseMixViewRequestListItemComponentList setComponentName(String componentName) {
            this.componentName = componentName;
            return this;
        }
        public String getComponentName() {
            return this.componentName;
        }

        public PurchaseMixViewRequestListItemComponentList setItemPropertyList(java.util.List<PurchaseMixViewRequestListItemComponentListItemPropertyList> itemPropertyList) {
            this.itemPropertyList = itemPropertyList;
            return this;
        }
        public java.util.List<PurchaseMixViewRequestListItemComponentListItemPropertyList> getItemPropertyList() {
            return this.itemPropertyList;
        }

    }

    public static class PurchaseMixViewRequestListMinorItemParamList extends TeaModel {
        @NameInMap("minorItemCode")
        public String minorItemCode;

        @NameInMap("minorItemGroupCode")
        public String minorItemGroupCode;

        public static PurchaseMixViewRequestListMinorItemParamList build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewRequestListMinorItemParamList self = new PurchaseMixViewRequestListMinorItemParamList();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewRequestListMinorItemParamList setMinorItemCode(String minorItemCode) {
            this.minorItemCode = minorItemCode;
            return this;
        }
        public String getMinorItemCode() {
            return this.minorItemCode;
        }

        public PurchaseMixViewRequestListMinorItemParamList setMinorItemGroupCode(String minorItemGroupCode) {
            this.minorItemGroupCode = minorItemGroupCode;
            return this;
        }
        public String getMinorItemGroupCode() {
            return this.minorItemGroupCode;
        }

    }

    public static class PurchaseMixViewRequestList extends TeaModel {
        @NameInMap("activityId")
        public Long activityId;

        @NameInMap("articleCode")
        public String articleCode;

        @NameInMap("articleItemCode")
        public String articleItemCode;

        @NameInMap("articleItemId")
        public Long articleItemId;

        @NameInMap("articleItemName")
        public String articleItemName;

        @NameInMap("bizType")
        public Long bizType;

        @NameInMap("couponId")
        public Long couponId;

        @NameInMap("cycNum")
        public Long cycNum;

        @NameInMap("cycType")
        public Long cycType;

        @NameInMap("cycUnit")
        public Long cycUnit;

        @NameInMap("extend1")
        public Long extend1;

        @NameInMap("instanceNum")
        public Long instanceNum;

        @NameInMap("isCredit")
        public Boolean isCredit;

        @NameInMap("itemComponentList")
        public java.util.List<PurchaseMixViewRequestListItemComponentList> itemComponentList;

        @NameInMap("minorItemParamList")
        public java.util.List<PurchaseMixViewRequestListMinorItemParamList> minorItemParamList;

        @NameInMap("orderParamMap")
        public java.util.Map<String, ?> orderParamMap;

        @NameInMap("orderType")
        public String orderType;

        @NameInMap("saleMarketType")
        public String saleMarketType;

        @NameInMap("saleOrgId")
        public Long saleOrgId;

        @NameInMap("subQuantity")
        public Long subQuantity;

        @NameInMap("tradeModelType")
        public String tradeModelType;

        public static PurchaseMixViewRequestList build(java.util.Map<String, ?> map) throws Exception {
            PurchaseMixViewRequestList self = new PurchaseMixViewRequestList();
            return TeaModel.build(map, self);
        }

        public PurchaseMixViewRequestList setActivityId(Long activityId) {
            this.activityId = activityId;
            return this;
        }
        public Long getActivityId() {
            return this.activityId;
        }

        public PurchaseMixViewRequestList setArticleCode(String articleCode) {
            this.articleCode = articleCode;
            return this;
        }
        public String getArticleCode() {
            return this.articleCode;
        }

        public PurchaseMixViewRequestList setArticleItemCode(String articleItemCode) {
            this.articleItemCode = articleItemCode;
            return this;
        }
        public String getArticleItemCode() {
            return this.articleItemCode;
        }

        public PurchaseMixViewRequestList setArticleItemId(Long articleItemId) {
            this.articleItemId = articleItemId;
            return this;
        }
        public Long getArticleItemId() {
            return this.articleItemId;
        }

        public PurchaseMixViewRequestList setArticleItemName(String articleItemName) {
            this.articleItemName = articleItemName;
            return this;
        }
        public String getArticleItemName() {
            return this.articleItemName;
        }

        public PurchaseMixViewRequestList setBizType(Long bizType) {
            this.bizType = bizType;
            return this;
        }
        public Long getBizType() {
            return this.bizType;
        }

        public PurchaseMixViewRequestList setCouponId(Long couponId) {
            this.couponId = couponId;
            return this;
        }
        public Long getCouponId() {
            return this.couponId;
        }

        public PurchaseMixViewRequestList setCycNum(Long cycNum) {
            this.cycNum = cycNum;
            return this;
        }
        public Long getCycNum() {
            return this.cycNum;
        }

        public PurchaseMixViewRequestList setCycType(Long cycType) {
            this.cycType = cycType;
            return this;
        }
        public Long getCycType() {
            return this.cycType;
        }

        public PurchaseMixViewRequestList setCycUnit(Long cycUnit) {
            this.cycUnit = cycUnit;
            return this;
        }
        public Long getCycUnit() {
            return this.cycUnit;
        }

        public PurchaseMixViewRequestList setExtend1(Long extend1) {
            this.extend1 = extend1;
            return this;
        }
        public Long getExtend1() {
            return this.extend1;
        }

        public PurchaseMixViewRequestList setInstanceNum(Long instanceNum) {
            this.instanceNum = instanceNum;
            return this;
        }
        public Long getInstanceNum() {
            return this.instanceNum;
        }

        public PurchaseMixViewRequestList setIsCredit(Boolean isCredit) {
            this.isCredit = isCredit;
            return this;
        }
        public Boolean getIsCredit() {
            return this.isCredit;
        }

        public PurchaseMixViewRequestList setItemComponentList(java.util.List<PurchaseMixViewRequestListItemComponentList> itemComponentList) {
            this.itemComponentList = itemComponentList;
            return this;
        }
        public java.util.List<PurchaseMixViewRequestListItemComponentList> getItemComponentList() {
            return this.itemComponentList;
        }

        public PurchaseMixViewRequestList setMinorItemParamList(java.util.List<PurchaseMixViewRequestListMinorItemParamList> minorItemParamList) {
            this.minorItemParamList = minorItemParamList;
            return this;
        }
        public java.util.List<PurchaseMixViewRequestListMinorItemParamList> getMinorItemParamList() {
            return this.minorItemParamList;
        }

        public PurchaseMixViewRequestList setOrderParamMap(java.util.Map<String, ?> orderParamMap) {
            this.orderParamMap = orderParamMap;
            return this;
        }
        public java.util.Map<String, ?> getOrderParamMap() {
            return this.orderParamMap;
        }

        public PurchaseMixViewRequestList setOrderType(String orderType) {
            this.orderType = orderType;
            return this;
        }
        public String getOrderType() {
            return this.orderType;
        }

        public PurchaseMixViewRequestList setSaleMarketType(String saleMarketType) {
            this.saleMarketType = saleMarketType;
            return this;
        }
        public String getSaleMarketType() {
            return this.saleMarketType;
        }

        public PurchaseMixViewRequestList setSaleOrgId(Long saleOrgId) {
            this.saleOrgId = saleOrgId;
            return this;
        }
        public Long getSaleOrgId() {
            return this.saleOrgId;
        }

        public PurchaseMixViewRequestList setSubQuantity(Long subQuantity) {
            this.subQuantity = subQuantity;
            return this;
        }
        public Long getSubQuantity() {
            return this.subQuantity;
        }

        public PurchaseMixViewRequestList setTradeModelType(String tradeModelType) {
            this.tradeModelType = tradeModelType;
            return this;
        }
        public String getTradeModelType() {
            return this.tradeModelType;
        }

    }

}
