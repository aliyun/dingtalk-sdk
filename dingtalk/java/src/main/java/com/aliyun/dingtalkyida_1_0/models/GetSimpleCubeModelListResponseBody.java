// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetSimpleCubeModelListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetSimpleCubeModelListResponseBodyResult> result;

    public static GetSimpleCubeModelListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSimpleCubeModelListResponseBody self = new GetSimpleCubeModelListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSimpleCubeModelListResponseBody setResult(java.util.List<GetSimpleCubeModelListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetSimpleCubeModelListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetSimpleCubeModelListResponseBodyResultChildren extends TeaModel {
        @NameInMap("classifiedCode")
        public String classifiedCode;

        @NameInMap("cubeCode")
        public String cubeCode;

        @NameInMap("dataType")
        public String dataType;

        @NameInMap("dimensionType")
        public String dimensionType;

        @NameInMap("fieldCode")
        public String fieldCode;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("id")
        public String id;

        @NameInMap("isDimension")
        public String isDimension;

        @NameInMap("isVisible")
        public String isVisible;

        @NameInMap("measureType")
        public String measureType;

        @NameInMap("text")
        public String text;

        @NameInMap("timeFormat")
        public String timeFormat;

        @NameInMap("timeGranularityType")
        public String timeGranularityType;

        public static GetSimpleCubeModelListResponseBodyResultChildren build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleCubeModelListResponseBodyResultChildren self = new GetSimpleCubeModelListResponseBodyResultChildren();
            return TeaModel.build(map, self);
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setClassifiedCode(String classifiedCode) {
            this.classifiedCode = classifiedCode;
            return this;
        }
        public String getClassifiedCode() {
            return this.classifiedCode;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setCubeCode(String cubeCode) {
            this.cubeCode = cubeCode;
            return this;
        }
        public String getCubeCode() {
            return this.cubeCode;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setDataType(String dataType) {
            this.dataType = dataType;
            return this;
        }
        public String getDataType() {
            return this.dataType;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setDimensionType(String dimensionType) {
            this.dimensionType = dimensionType;
            return this;
        }
        public String getDimensionType() {
            return this.dimensionType;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setFieldCode(String fieldCode) {
            this.fieldCode = fieldCode;
            return this;
        }
        public String getFieldCode() {
            return this.fieldCode;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setIsDimension(String isDimension) {
            this.isDimension = isDimension;
            return this;
        }
        public String getIsDimension() {
            return this.isDimension;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setIsVisible(String isVisible) {
            this.isVisible = isVisible;
            return this;
        }
        public String getIsVisible() {
            return this.isVisible;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setMeasureType(String measureType) {
            this.measureType = measureType;
            return this;
        }
        public String getMeasureType() {
            return this.measureType;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setTimeFormat(String timeFormat) {
            this.timeFormat = timeFormat;
            return this;
        }
        public String getTimeFormat() {
            return this.timeFormat;
        }

        public GetSimpleCubeModelListResponseBodyResultChildren setTimeGranularityType(String timeGranularityType) {
            this.timeGranularityType = timeGranularityType;
            return this;
        }
        public String getTimeGranularityType() {
            return this.timeGranularityType;
        }

    }

    public static class GetSimpleCubeModelListResponseBodyResult extends TeaModel {
        @NameInMap("children")
        public java.util.List<GetSimpleCubeModelListResponseBodyResultChildren> children;

        /**
         * <strong>example:</strong>
         * <p>12345</p>
         */
        @NameInMap("id")
        public String id;

        @NameInMap("isDimension")
        public String isDimension;

        @NameInMap("text")
        public String text;

        public static GetSimpleCubeModelListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSimpleCubeModelListResponseBodyResult self = new GetSimpleCubeModelListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSimpleCubeModelListResponseBodyResult setChildren(java.util.List<GetSimpleCubeModelListResponseBodyResultChildren> children) {
            this.children = children;
            return this;
        }
        public java.util.List<GetSimpleCubeModelListResponseBodyResultChildren> getChildren() {
            return this.children;
        }

        public GetSimpleCubeModelListResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetSimpleCubeModelListResponseBodyResult setIsDimension(String isDimension) {
            this.isDimension = isDimension;
            return this;
        }
        public String getIsDimension() {
            return this.isDimension;
        }

        public GetSimpleCubeModelListResponseBodyResult setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

    }

}
