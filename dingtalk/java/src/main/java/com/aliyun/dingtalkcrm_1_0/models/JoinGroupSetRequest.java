// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class JoinGroupSetRequest extends TeaModel {
    /**
     * <p>关系模型数据。</p>
     */
    @NameInMap("bizDataList")
    public java.util.List<JoinGroupSetRequestBizDataList> bizDataList;

    /**
     * <p>组织id。</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>群组openGroupSetId。</p>
     */
    @NameInMap("openGroupSetId")
    public String openGroupSetId;

    /**
     * <p>unionId。</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static JoinGroupSetRequest build(java.util.Map<String, ?> map) throws Exception {
        JoinGroupSetRequest self = new JoinGroupSetRequest();
        return TeaModel.build(map, self);
    }

    public JoinGroupSetRequest setBizDataList(java.util.List<JoinGroupSetRequestBizDataList> bizDataList) {
        this.bizDataList = bizDataList;
        return this;
    }
    public java.util.List<JoinGroupSetRequestBizDataList> getBizDataList() {
        return this.bizDataList;
    }

    public JoinGroupSetRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public JoinGroupSetRequest setOpenGroupSetId(String openGroupSetId) {
        this.openGroupSetId = openGroupSetId;
        return this;
    }
    public String getOpenGroupSetId() {
        return this.openGroupSetId;
    }

    public JoinGroupSetRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class JoinGroupSetRequestBizDataList extends TeaModel {
        /**
         * <p>关系模型数据字段扩展值。</p>
         */
        @NameInMap("extendValue")
        public String extendValue;

        /**
         * <p>关系模型数据字段名。</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>关系模型数据字段值。</p>
         */
        @NameInMap("value")
        public String value;

        public static JoinGroupSetRequestBizDataList build(java.util.Map<String, ?> map) throws Exception {
            JoinGroupSetRequestBizDataList self = new JoinGroupSetRequestBizDataList();
            return TeaModel.build(map, self);
        }

        public JoinGroupSetRequestBizDataList setExtendValue(String extendValue) {
            this.extendValue = extendValue;
            return this;
        }
        public String getExtendValue() {
            return this.extendValue;
        }

        public JoinGroupSetRequestBizDataList setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public JoinGroupSetRequestBizDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
