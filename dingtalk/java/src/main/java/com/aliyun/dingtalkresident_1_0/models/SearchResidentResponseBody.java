// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class SearchResidentResponseBody extends TeaModel {
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
        @NameInMap("active")
        public Boolean active;

        @NameInMap("extField")
        public String extField;

        @NameInMap("isPropertyOwner")
        public Boolean isPropertyOwner;

        @NameInMap("name")
        public String name;

        @NameInMap("relateType")
        public String relateType;

        public static SearchResidentResponseBodyResidenceList build(java.util.Map<String, ?> map) throws Exception {
            SearchResidentResponseBodyResidenceList self = new SearchResidentResponseBodyResidenceList();
            return TeaModel.build(map, self);
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

        public SearchResidentResponseBodyResidenceList setIsPropertyOwner(Boolean isPropertyOwner) {
            this.isPropertyOwner = isPropertyOwner;
            return this;
        }
        public Boolean getIsPropertyOwner() {
            return this.isPropertyOwner;
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

    }

}
