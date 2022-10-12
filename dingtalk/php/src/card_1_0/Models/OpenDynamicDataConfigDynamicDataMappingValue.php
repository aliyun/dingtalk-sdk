<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenDynamicDataConfigDynamicDataMappingValue extends Model
{
    /**
     * @description jsonPath
     *
     * @var string
     */
    public $path;

    /**
     * @description 值的类型 (STRING: String, ARRAY: 数组, OBJECT: 对象, CHART: 图表, TABLE: 表格, INDICATOR: 指标卡)
     *
     * @var string
     */
    public $dynamicDataValueType;
    protected $_name = [
        'path'                 => 'path',
        'dynamicDataValueType' => 'dynamicDataValueType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->dynamicDataValueType) {
            $res['dynamicDataValueType'] = $this->dynamicDataValueType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenDynamicDataConfigDynamicDataMappingValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['dynamicDataValueType'])) {
            $model->dynamicDataValueType = $map['dynamicDataValueType'];
        }

        return $model;
    }
}
