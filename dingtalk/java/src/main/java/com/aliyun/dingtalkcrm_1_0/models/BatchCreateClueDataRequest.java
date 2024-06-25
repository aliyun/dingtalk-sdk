// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateClueDataRequest extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<BatchCreateClueDataRequestDataList> dataList;

    @NameInMap("privateSeas")
    public Boolean privateSeas;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>d124</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BatchCreateClueDataRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateClueDataRequest self = new BatchCreateClueDataRequest();
        return TeaModel.build(map, self);
    }

    public BatchCreateClueDataRequest setDataList(java.util.List<BatchCreateClueDataRequestDataList> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<BatchCreateClueDataRequestDataList> getDataList() {
        return this.dataList;
    }

    public BatchCreateClueDataRequest setPrivateSeas(Boolean privateSeas) {
        this.privateSeas = privateSeas;
        return this;
    }
    public Boolean getPrivateSeas() {
        return this.privateSeas;
    }

    public BatchCreateClueDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class BatchCreateClueDataRequestDataListContactList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("phone")
        public String phone;

        @NameInMap("qq")
        public String qq;

        @NameInMap("wangWang")
        public String wangWang;

        @NameInMap("weChat")
        public String weChat;

        public static BatchCreateClueDataRequestDataListContactList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateClueDataRequestDataListContactList self = new BatchCreateClueDataRequestDataListContactList();
            return TeaModel.build(map, self);
        }

        public BatchCreateClueDataRequestDataListContactList setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public BatchCreateClueDataRequestDataListContactList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchCreateClueDataRequestDataListContactList setPhone(String phone) {
            this.phone = phone;
            return this;
        }
        public String getPhone() {
            return this.phone;
        }

        public BatchCreateClueDataRequestDataListContactList setQq(String qq) {
            this.qq = qq;
            return this;
        }
        public String getQq() {
            return this.qq;
        }

        public BatchCreateClueDataRequestDataListContactList setWangWang(String wangWang) {
            this.wangWang = wangWang;
            return this;
        }
        public String getWangWang() {
            return this.wangWang;
        }

        public BatchCreateClueDataRequestDataListContactList setWeChat(String weChat) {
            this.weChat = weChat;
            return this;
        }
        public String getWeChat() {
            return this.weChat;
        }

    }

    public static class BatchCreateClueDataRequestDataListEnterprise extends TeaModel {
        @NameInMap("address")
        public String address;

        @NameInMap("industryCode")
        public String industryCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("region")
        public String region;

        @NameInMap("unifiedSocialCreditCode")
        public String unifiedSocialCreditCode;

        public static BatchCreateClueDataRequestDataListEnterprise build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateClueDataRequestDataListEnterprise self = new BatchCreateClueDataRequestDataListEnterprise();
            return TeaModel.build(map, self);
        }

        public BatchCreateClueDataRequestDataListEnterprise setAddress(String address) {
            this.address = address;
            return this;
        }
        public String getAddress() {
            return this.address;
        }

        public BatchCreateClueDataRequestDataListEnterprise setIndustryCode(String industryCode) {
            this.industryCode = industryCode;
            return this;
        }
        public String getIndustryCode() {
            return this.industryCode;
        }

        public BatchCreateClueDataRequestDataListEnterprise setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchCreateClueDataRequestDataListEnterprise setRegion(String region) {
            this.region = region;
            return this;
        }
        public String getRegion() {
            return this.region;
        }

        public BatchCreateClueDataRequestDataListEnterprise setUnifiedSocialCreditCode(String unifiedSocialCreditCode) {
            this.unifiedSocialCreditCode = unifiedSocialCreditCode;
            return this;
        }
        public String getUnifiedSocialCreditCode() {
            return this.unifiedSocialCreditCode;
        }

    }

    public static class BatchCreateClueDataRequestDataListTagIdList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("tagId")
        public String tagId;

        @NameInMap("tagName")
        public String tagName;

        public static BatchCreateClueDataRequestDataListTagIdList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateClueDataRequestDataListTagIdList self = new BatchCreateClueDataRequestDataListTagIdList();
            return TeaModel.build(map, self);
        }

        public BatchCreateClueDataRequestDataListTagIdList setTagId(String tagId) {
            this.tagId = tagId;
            return this;
        }
        public String getTagId() {
            return this.tagId;
        }

        public BatchCreateClueDataRequestDataListTagIdList setTagName(String tagName) {
            this.tagName = tagName;
            return this;
        }
        public String getTagName() {
            return this.tagName;
        }

    }

    public static class BatchCreateClueDataRequestDataList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("contactList")
        public java.util.List<BatchCreateClueDataRequestDataListContactList> contactList;

        @NameInMap("enterprise")
        public BatchCreateClueDataRequestDataListEnterprise enterprise;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>钉钉中国</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("sourceId")
        public String sourceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>demo</p>
         */
        @NameInMap("sourceType")
        public String sourceType;

        @NameInMap("tagIdList")
        public java.util.List<BatchCreateClueDataRequestDataListTagIdList> tagIdList;

        public static BatchCreateClueDataRequestDataList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateClueDataRequestDataList self = new BatchCreateClueDataRequestDataList();
            return TeaModel.build(map, self);
        }

        public BatchCreateClueDataRequestDataList setContactList(java.util.List<BatchCreateClueDataRequestDataListContactList> contactList) {
            this.contactList = contactList;
            return this;
        }
        public java.util.List<BatchCreateClueDataRequestDataListContactList> getContactList() {
            return this.contactList;
        }

        public BatchCreateClueDataRequestDataList setEnterprise(BatchCreateClueDataRequestDataListEnterprise enterprise) {
            this.enterprise = enterprise;
            return this;
        }
        public BatchCreateClueDataRequestDataListEnterprise getEnterprise() {
            return this.enterprise;
        }

        public BatchCreateClueDataRequestDataList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public BatchCreateClueDataRequestDataList setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public BatchCreateClueDataRequestDataList setSourceType(String sourceType) {
            this.sourceType = sourceType;
            return this;
        }
        public String getSourceType() {
            return this.sourceType;
        }

        public BatchCreateClueDataRequestDataList setTagIdList(java.util.List<BatchCreateClueDataRequestDataListTagIdList> tagIdList) {
            this.tagIdList = tagIdList;
            return this;
        }
        public java.util.List<BatchCreateClueDataRequestDataListTagIdList> getTagIdList() {
            return this.tagIdList;
        }

    }

}
