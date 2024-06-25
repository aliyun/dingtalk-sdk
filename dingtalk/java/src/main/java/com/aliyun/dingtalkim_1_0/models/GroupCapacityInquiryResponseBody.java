// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityInquiryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>85000</p>
     */
    @NameInMap("actualPrice")
    public Long actualPrice;

    /**
     * <strong>example:</strong>
     * <p>1652183395772</p>
     */
    @NameInMap("createdAt")
    public Long createdAt;

    /**
     * <strong>example:</strong>
     * <p>500</p>
     */
    @NameInMap("currentCapacity")
    public Integer currentCapacity;

    /**
     * <strong>example:</strong>
     * <p>1652183395772</p>
     */
    @NameInMap("currentEffectUntil")
    public Long currentEffectUntil;

    /**
     * <strong>example:</strong>
     * <p>85</p>
     */
    @NameInMap("discount")
    public Integer discount;

    @NameInMap("extInfo")
    public java.util.Map<String, ?> extInfo;

    /**
     * <strong>example:</strong>
     * <p>678912390478123</p>
     */
    @NameInMap("groupOwner")
    public String groupOwner;

    /**
     * <strong>example:</strong>
     * <p>今天吃肘子群</p>
     */
    @NameInMap("groupTitle")
    public String groupTitle;

    /**
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("markedPrice")
    public Long markedPrice;

    /**
     * <strong>example:</strong>
     * <p>500</p>
     */
    @NameInMap("memberCount")
    public Integer memberCount;

    /**
     * <strong>example:</strong>
     * <p>cidoondswfakscdviouhao==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>32453245234523425</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <strong>example:</strong>
     * <p>10000</p>
     */
    @NameInMap("targetCapacity")
    public Integer targetCapacity;

    /**
     * <strong>example:</strong>
     * <p>1652183395772</p>
     */
    @NameInMap("targetEffectUntil")
    public Long targetEffectUntil;

    /**
     * <strong>example:</strong>
     * <p>jklasdhjfasdjkfkh421jk5bb243b523</p>
     */
    @NameInMap("token")
    public String token;

    public static GroupCapacityInquiryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityInquiryResponseBody self = new GroupCapacityInquiryResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupCapacityInquiryResponseBody setActualPrice(Long actualPrice) {
        this.actualPrice = actualPrice;
        return this;
    }
    public Long getActualPrice() {
        return this.actualPrice;
    }

    public GroupCapacityInquiryResponseBody setCreatedAt(Long createdAt) {
        this.createdAt = createdAt;
        return this;
    }
    public Long getCreatedAt() {
        return this.createdAt;
    }

    public GroupCapacityInquiryResponseBody setCurrentCapacity(Integer currentCapacity) {
        this.currentCapacity = currentCapacity;
        return this;
    }
    public Integer getCurrentCapacity() {
        return this.currentCapacity;
    }

    public GroupCapacityInquiryResponseBody setCurrentEffectUntil(Long currentEffectUntil) {
        this.currentEffectUntil = currentEffectUntil;
        return this;
    }
    public Long getCurrentEffectUntil() {
        return this.currentEffectUntil;
    }

    public GroupCapacityInquiryResponseBody setDiscount(Integer discount) {
        this.discount = discount;
        return this;
    }
    public Integer getDiscount() {
        return this.discount;
    }

    public GroupCapacityInquiryResponseBody setExtInfo(java.util.Map<String, ?> extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public java.util.Map<String, ?> getExtInfo() {
        return this.extInfo;
    }

    public GroupCapacityInquiryResponseBody setGroupOwner(String groupOwner) {
        this.groupOwner = groupOwner;
        return this;
    }
    public String getGroupOwner() {
        return this.groupOwner;
    }

    public GroupCapacityInquiryResponseBody setGroupTitle(String groupTitle) {
        this.groupTitle = groupTitle;
        return this;
    }
    public String getGroupTitle() {
        return this.groupTitle;
    }

    public GroupCapacityInquiryResponseBody setMarkedPrice(Long markedPrice) {
        this.markedPrice = markedPrice;
        return this;
    }
    public Long getMarkedPrice() {
        return this.markedPrice;
    }

    public GroupCapacityInquiryResponseBody setMemberCount(Integer memberCount) {
        this.memberCount = memberCount;
        return this;
    }
    public Integer getMemberCount() {
        return this.memberCount;
    }

    public GroupCapacityInquiryResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GroupCapacityInquiryResponseBody setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GroupCapacityInquiryResponseBody setTargetCapacity(Integer targetCapacity) {
        this.targetCapacity = targetCapacity;
        return this;
    }
    public Integer getTargetCapacity() {
        return this.targetCapacity;
    }

    public GroupCapacityInquiryResponseBody setTargetEffectUntil(Long targetEffectUntil) {
        this.targetEffectUntil = targetEffectUntil;
        return this;
    }
    public Long getTargetEffectUntil() {
        return this.targetEffectUntil;
    }

    public GroupCapacityInquiryResponseBody setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
