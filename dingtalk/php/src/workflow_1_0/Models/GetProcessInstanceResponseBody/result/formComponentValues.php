<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result;

use AlibabaCloud\Tea\Model;

class formComponentValues extends Model
{
    /**
     * @example TextField-bizAlias
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @example DDSelectField
     *
     * @var string
     */
    public $componentType;

    /**
     * @example 示例值
     *
     * @var string
     */
    public $extValue;

    /**
     * @example DDHolidayField-J2Bxxxx
     *
     * @var string
     */
    public $id;

    /**
     * @example 组件1
     *
     * @var string
     */
    public $name;

    /**
     * @example 示例值
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'bizAlias'      => 'bizAlias',
        'componentType' => 'componentType',
        'extValue'      => 'extValue',
        'id'            => 'id',
        'name'          => 'name',
        'value'         => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->componentType) {
            $res['componentType'] = $this->componentType;
        }
        if (null !== $this->extValue) {
            $res['extValue'] = $this->extValue;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return formComponentValues
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['componentType'])) {
            $model->componentType = $map['componentType'];
        }
        if (isset($map['extValue'])) {
            $model->extValue = $map['extValue'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
