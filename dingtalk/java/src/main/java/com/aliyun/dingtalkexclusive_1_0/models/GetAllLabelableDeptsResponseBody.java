// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAllLabelableDeptsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("data")
    public java.util.List<GetAllLabelableDeptsResponseBodyData> data;

    public static GetAllLabelableDeptsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllLabelableDeptsResponseBody self = new GetAllLabelableDeptsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllLabelableDeptsResponseBody setData(java.util.List<GetAllLabelableDeptsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetAllLabelableDeptsResponseBodyData> getData() {
        return this.data;
    }

    public static class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("labelId")
        public Long labelId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>一级供应商</p>
         */
        @NameInMap("labelName")
        public String labelName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("levelNum")
        public Long levelNum;

        public static GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 build(java.util.Map<String, ?> map) throws Exception {
            GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 self = new GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1();
            return TeaModel.build(map, self);
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 setLevelNum(Long levelNum) {
            this.levelNum = levelNum;
            return this;
        }
        public Long getLevelNum() {
            return this.levelNum;
        }

    }

    public static class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("labelId")
        public Long labelId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>二级供应商</p>
         */
        @NameInMap("labelName")
        public String labelName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("levelNum")
        public Long levelNum;

        public static GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 build(java.util.Map<String, ?> map) throws Exception {
            GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 self = new GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2();
            return TeaModel.build(map, self);
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 setLevelNum(Long levelNum) {
            this.levelNum = levelNum;
            return this;
        }
        public Long getLevelNum() {
            return this.levelNum;
        }

    }

    public static class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("labelId")
        public Long labelId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>三级供应商</p>
         */
        @NameInMap("labelName")
        public String labelName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("levelNum")
        public Long levelNum;

        public static GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 build(java.util.Map<String, ?> map) throws Exception {
            GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 self = new GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3();
            return TeaModel.build(map, self);
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 setLevelNum(Long levelNum) {
            this.levelNum = levelNum;
            return this;
        }
        public Long getLevelNum() {
            return this.levelNum;
        }

    }

    public static class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("labelId")
        public Long labelId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>四级供应商</p>
         */
        @NameInMap("labelName")
        public String labelName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>4</p>
         */
        @NameInMap("levelNum")
        public Long levelNum;

        public static GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 build(java.util.Map<String, ?> map) throws Exception {
            GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 self = new GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4();
            return TeaModel.build(map, self);
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 setLevelNum(Long levelNum) {
            this.levelNum = levelNum;
            return this;
        }
        public Long getLevelNum() {
            return this.levelNum;
        }

    }

    public static class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("labelId")
        public Long labelId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>五级供应商</p>
         */
        @NameInMap("labelName")
        public String labelName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>5</p>
         */
        @NameInMap("levelNum")
        public Long levelNum;

        public static GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 build(java.util.Map<String, ?> map) throws Exception {
            GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 self = new GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5();
            return TeaModel.build(map, self);
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 setLabelId(Long labelId) {
            this.labelId = labelId;
            return this;
        }
        public Long getLabelId() {
            return this.labelId;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 setLabelName(String labelName) {
            this.labelName = labelName;
            return this;
        }
        public String getLabelName() {
            return this.labelName;
        }

        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 setLevelNum(Long levelNum) {
            this.levelNum = levelNum;
            return this;
        }
        public Long getLevelNum() {
            return this.levelNum;
        }

    }

    public static class GetAllLabelableDeptsResponseBodyData extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("deptId")
        public String deptId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>管理部</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("memberCount")
        public Long memberCount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("partnerLabelVOLevel1")
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 partnerLabelVOLevel1;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("partnerLabelVOLevel2")
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 partnerLabelVOLevel2;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("partnerLabelVOLevel3")
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 partnerLabelVOLevel3;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("partnerLabelVOLevel4")
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 partnerLabelVOLevel4;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("partnerLabelVOLevel5")
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 partnerLabelVOLevel5;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("partnerNum")
        public String partnerNum;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("superDeptId")
        public String superDeptId;

        public static GetAllLabelableDeptsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetAllLabelableDeptsResponseBodyData self = new GetAllLabelableDeptsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetAllLabelableDeptsResponseBodyData setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public GetAllLabelableDeptsResponseBodyData setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetAllLabelableDeptsResponseBodyData setMemberCount(Long memberCount) {
            this.memberCount = memberCount;
            return this;
        }
        public Long getMemberCount() {
            return this.memberCount;
        }

        public GetAllLabelableDeptsResponseBodyData setPartnerLabelVOLevel1(GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 partnerLabelVOLevel1) {
            this.partnerLabelVOLevel1 = partnerLabelVOLevel1;
            return this;
        }
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 getPartnerLabelVOLevel1() {
            return this.partnerLabelVOLevel1;
        }

        public GetAllLabelableDeptsResponseBodyData setPartnerLabelVOLevel2(GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 partnerLabelVOLevel2) {
            this.partnerLabelVOLevel2 = partnerLabelVOLevel2;
            return this;
        }
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 getPartnerLabelVOLevel2() {
            return this.partnerLabelVOLevel2;
        }

        public GetAllLabelableDeptsResponseBodyData setPartnerLabelVOLevel3(GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 partnerLabelVOLevel3) {
            this.partnerLabelVOLevel3 = partnerLabelVOLevel3;
            return this;
        }
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 getPartnerLabelVOLevel3() {
            return this.partnerLabelVOLevel3;
        }

        public GetAllLabelableDeptsResponseBodyData setPartnerLabelVOLevel4(GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 partnerLabelVOLevel4) {
            this.partnerLabelVOLevel4 = partnerLabelVOLevel4;
            return this;
        }
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 getPartnerLabelVOLevel4() {
            return this.partnerLabelVOLevel4;
        }

        public GetAllLabelableDeptsResponseBodyData setPartnerLabelVOLevel5(GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 partnerLabelVOLevel5) {
            this.partnerLabelVOLevel5 = partnerLabelVOLevel5;
            return this;
        }
        public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 getPartnerLabelVOLevel5() {
            return this.partnerLabelVOLevel5;
        }

        public GetAllLabelableDeptsResponseBodyData setPartnerNum(String partnerNum) {
            this.partnerNum = partnerNum;
            return this;
        }
        public String getPartnerNum() {
            return this.partnerNum;
        }

        public GetAllLabelableDeptsResponseBodyData setSuperDeptId(String superDeptId) {
            this.superDeptId = superDeptId;
            return this;
        }
        public String getSuperDeptId() {
            return this.superDeptId;
        }

    }

}
