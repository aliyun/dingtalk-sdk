// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GroupQueryByAttrRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("groupTopic")
    public String groupTopic;

    @NameInMap("groupType")
    public String groupType;

    @NameInMap("listDynamicAttr")
    public java.util.List<GroupQueryByAttrRequestListDynamicAttr> listDynamicAttr;

    @NameInMap("pageIndex")
    public Integer pageIndex;

    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("secretKey")
    public String secretKey;

    public static GroupQueryByAttrRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupQueryByAttrRequest self = new GroupQueryByAttrRequest();
        return TeaModel.build(map, self);
    }

    public GroupQueryByAttrRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GroupQueryByAttrRequest setGroupTopic(String groupTopic) {
        this.groupTopic = groupTopic;
        return this;
    }
    public String getGroupTopic() {
        return this.groupTopic;
    }

    public GroupQueryByAttrRequest setGroupType(String groupType) {
        this.groupType = groupType;
        return this;
    }
    public String getGroupType() {
        return this.groupType;
    }

    public GroupQueryByAttrRequest setListDynamicAttr(java.util.List<GroupQueryByAttrRequestListDynamicAttr> listDynamicAttr) {
        this.listDynamicAttr = listDynamicAttr;
        return this;
    }
    public java.util.List<GroupQueryByAttrRequestListDynamicAttr> getListDynamicAttr() {
        return this.listDynamicAttr;
    }

    public GroupQueryByAttrRequest setPageIndex(Integer pageIndex) {
        this.pageIndex = pageIndex;
        return this;
    }
    public Integer getPageIndex() {
        return this.pageIndex;
    }

    public GroupQueryByAttrRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GroupQueryByAttrRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public static class GroupQueryByAttrRequestListDynamicAttr extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("attrCode")
        public String attrCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("listAttrOptionsCode")
        public java.util.List<String> listAttrOptionsCode;

        public static GroupQueryByAttrRequestListDynamicAttr build(java.util.Map<String, ?> map) throws Exception {
            GroupQueryByAttrRequestListDynamicAttr self = new GroupQueryByAttrRequestListDynamicAttr();
            return TeaModel.build(map, self);
        }

        public GroupQueryByAttrRequestListDynamicAttr setAttrCode(String attrCode) {
            this.attrCode = attrCode;
            return this;
        }
        public String getAttrCode() {
            return this.attrCode;
        }

        public GroupQueryByAttrRequestListDynamicAttr setListAttrOptionsCode(java.util.List<String> listAttrOptionsCode) {
            this.listAttrOptionsCode = listAttrOptionsCode;
            return this;
        }
        public java.util.List<String> getListAttrOptionsCode() {
            return this.listAttrOptionsCode;
        }

    }

}
