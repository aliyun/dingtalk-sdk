// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class SearchResidentResponseBody extends TeaModel {
    // result
    @NameInMap("residenceList")
    public java.util.List<SearchResidentResponseBodyResidenceList> residenceList;

    public static SearchResidentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchResidentResponseBody self = new SearchResidentResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchResidentResponseBody setResidenceList(java.util.List<SearchResidentResponseBodyResidenceList> residenceList) {
        this.residenceList = residenceList;
        return this;
    }
    public java.util.List<SearchResidentResponseBodyResidenceList> getResidenceList() {
        return this.residenceList;
    }

    public static class SearchResidentResponseBodyResidenceList extends TeaModel {
        @NameInMap("name")
        public String name;

        // 业主/租客/亲友等
        @NameInMap("relateType")
        public String relateType;

        // 是否是产权人
        @NameInMap("isPropertyOwner")
        public Boolean isPropertyOwner;

        // 是否激活
        @NameInMap("active")
        public Boolean active;

        // 扩展字段，如果是租客存起止时间
        @NameInMap("extField")
        public String extField;

        public static SearchResidentResponseBodyResidenceList build(java.util.Map<String, ?> map) throws Exception {
            SearchResidentResponseBodyResidenceList self = new SearchResidentResponseBodyResidenceList();
            return TeaModel.build(map, self);
        }

        public SearchResidentResponseBodyResidenceList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchResidentResponseBodyResidenceList setRelateType(String relateType) {
            this.relateType = relateType;
            return this;
        }
        public String getRelateType() {
            return this.relateType;
        }

        public SearchResidentResponseBodyResidenceList setIsPropertyOwner(Boolean isPropertyOwner) {
            this.isPropertyOwner = isPropertyOwner;
            return this;
        }
        public Boolean getIsPropertyOwner() {
            return this.isPropertyOwner;
        }

        public SearchResidentResponseBodyResidenceList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public SearchResidentResponseBodyResidenceList setExtField(String extField) {
            this.extField = extField;
            return this;
        }
        public String getExtField() {
            return this.extField;
        }

    }

}
