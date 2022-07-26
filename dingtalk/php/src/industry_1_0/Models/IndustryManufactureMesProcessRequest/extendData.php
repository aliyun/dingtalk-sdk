<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesProcessRequest;

use AlibabaCloud\Tea\Model;

class extendData extends Model
{
    /**
     * @description 扩展字段唯一标识(英文)
     *
     * @var string
     */
    public $code;

    /**
     * @description 扩展字段中文描述
     *
     * @var string
     */
    public $name;

    /**
     * @description 扩展字段实际取值
     *
     * @var string
     */
    public $value;

    /**
     * @description 扩展字段类型,例如string
     *
     * @var string
     */
    public $valueType;
    protected $_name = [
        'code'      => 'code',
        'name'      => 'name',
        'value'     => 'value',
        'valueType' => 'valueType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->valueType) {
            $res['valueType'] = $this->valueType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extendData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['valueType'])) {
            $model->valueType = $map['valueType'];
        }

        return $model;
    }
}
