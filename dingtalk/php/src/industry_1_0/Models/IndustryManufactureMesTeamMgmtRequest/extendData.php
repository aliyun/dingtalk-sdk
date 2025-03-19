<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\IndustryManufactureMesTeamMgmtRequest;

use AlibabaCloud\Tea\Model;

class extendData extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example school
     *
     * @var string
     */
    public $code;

    /**
     * @example 学校
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 北大
     *
     * @var string
     */
    public $value;

    /**
     * @description This parameter is required.
     *
     * @example string
     *
     * @var string
     */
    public $valueType;
    protected $_name = [
        'code' => 'code',
        'name' => 'name',
        'value' => 'value',
        'valueType' => 'valueType',
    ];

    public function validate() {}

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
