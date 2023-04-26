// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentMembersInfoResponseBody extends TeaModel {
    @NameInMap("residenceList")
    public java.util.List<GetResidentMembersInfoResponseBodyResidenceList> residenceList;

    public static GetResidentMembersInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResidentMembersInfoResponseBody self = new GetResidentMembersInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResidentMembersInfoResponseBody setResidenceList(java.util.List<GetResidentMembersInfoResponseBodyResidenceList> residenceList) {
        this.residenceList = residenceList;
        return this;
    }
    public java.util.List<GetResidentMembersInfoResponseBodyResidenceList> getResidenceList() {
        return this.residenceList;
    }

    public static class GetResidentMembersInfoResponseBodyResidenceList extends TeaModel {
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

        public static GetResidentMembersInfoResponseBodyResidenceList build(java.util.Map<String, ?> map) throws Exception {
            GetResidentMembersInfoResponseBodyResidenceList self = new GetResidentMembersInfoResponseBodyResidenceList();
            return TeaModel.build(map, self);
        }

        public GetResidentMembersInfoResponseBodyResidenceList setActive(Boolean active) {
            this.active = active;
            return this;
        }
        public Boolean getActive() {
            return this.active;
        }

        public GetResidentMembersInfoResponseBodyResidenceList setExtField(String extField) {
            this.extField = extField;
            return this;
        }
        public String getExtField() {
            return this.extField;
        }

        public GetResidentMembersInfoResponseBodyResidenceList setIsPropertyOwner(Boolean isPropertyOwner) {
            this.isPropertyOwner = isPropertyOwner;
            return this;
        }
        public Boolean getIsPropertyOwner() {
            return this.isPropertyOwner;
        }

        public GetResidentMembersInfoResponseBodyResidenceList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetResidentMembersInfoResponseBodyResidenceList setRelateType(String relateType) {
            this.relateType = relateType;
            return this;
        }
        public String getRelateType() {
            return this.relateType;
        }

    }

}
