// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryPartnerInfoResponseBody extends TeaModel {
    @NameInMap("partnerDeptList")
    public java.util.List<QueryPartnerInfoResponseBodyPartnerDeptList> partnerDeptList;

    @NameInMap("partnerLabelList")
    public java.util.List<QueryPartnerInfoResponseBodyPartnerLabelList> partnerLabelList;

    @NameInMap("userId")
    public String userId;

    public static QueryPartnerInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPartnerInfoResponseBody self = new QueryPartnerInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPartnerInfoResponseBody setPartnerDeptList(java.util.List<QueryPartnerInfoResponseBodyPartnerDeptList> partnerDeptList) {
        this.partnerDeptList = partnerDeptList;
        return this;
    }
    public java.util.List<QueryPartnerInfoResponseBodyPartnerDeptList> getPartnerDeptList() {
        return this.partnerDeptList;
    }

    public QueryPartnerInfoResponseBody setPartnerLabelList(java.util.List<QueryPartnerInfoResponseBodyPartnerLabelList> partnerLabelList) {
        this.partnerLabelList = partnerLabelList;
        return this;
    }
    public java.util.List<QueryPartnerInfoResponseBodyPartnerLabelList> getPartnerLabelList() {
        return this.partnerLabelList;
    }

    public QueryPartnerInfoResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 extends TeaModel {
        @NameInMap("labelId")
        public Long labelId;

        @NameInMap("labelname")
        public String labelname;

        public static QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 build(java.util.Map<String, ?> map) throws Exception {
            QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 self = new QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1();
            return TeaModel.build(map, self);
        }

        public QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 setLabelname(String labelname) {
            this.labelname = labelname;
            return this;
        }
        public String getLabelname() {
            return this.labelname;
        }

    }

    public static class QueryPartnerInfoResponseBodyPartnerDeptList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("memberCount")
        public Long memberCount;

        @NameInMap("partnerLabelModelLevel1")
        public QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 partnerLabelModelLevel1;

        @NameInMap("partnerNum")
        public String partnerNum;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("value")
        public String value;

        public static QueryPartnerInfoResponseBodyPartnerDeptList build(java.util.Map<String, ?> map) throws Exception {
            QueryPartnerInfoResponseBodyPartnerDeptList self = new QueryPartnerInfoResponseBodyPartnerDeptList();
            return TeaModel.build(map, self);
        }

        public QueryPartnerInfoResponseBodyPartnerDeptList setMemberCount(Long memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Long getMemberCount() {
            return this.memberCount;
        }

        public QueryPartnerInfoResponseBodyPartnerDeptList setPartnerLabelModelLevel1(QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 partnerLabelModelLevel1) {
            this.partnerLabelModelLevel1 = partnerLabelModelLevel1;
            return this;
        }
        public QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 getPartnerLabelModelLevel1() {
            return this.partnerLabelModelLevel1;
        }

        public QueryPartnerInfoResponseBodyPartnerDeptList setPartnerNum(String partnerNum) {
            this.partnerNum = partnerNum;
            return this;
        }
        public String getPartnerNum() {
            return this.partnerNum;
        }

        public QueryPartnerInfoResponseBodyPartnerDeptList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public QueryPartnerInfoResponseBodyPartnerDeptList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class QueryPartnerInfoResponseBodyPartnerLabelList extends TeaModel {
        @NameInMap("id")
        public Long id;

        @NameInMap("name")
        public String name;

        public static QueryPartnerInfoResponseBodyPartnerLabelList build(java.util.Map<String, ?> map) throws Exception {
            QueryPartnerInfoResponseBodyPartnerLabelList self = new QueryPartnerInfoResponseBodyPartnerLabelList();
            return TeaModel.build(map, self);
        }

        public QueryPartnerInfoResponseBodyPartnerLabelList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryPartnerInfoResponseBodyPartnerLabelList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
