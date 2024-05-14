<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\StartProcessInstanceRequest\formComponentValues\details;
use AlibabaCloud\Tea\Model;

class formComponentValues extends Model
{
    /**
     * @example Phone
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @var string
     */
    public $componentType;

    /**
     * @var details[]
     */
    public $details;

    /**
     * @example 总个数:1
     *
     * @var string
     */
    public $extValue;

    /**
     * @example PhoneField_IZI2LP8QF6O0
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example PhoneField
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 123xxxxxxxx
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'bizAlias'      => 'bizAlias',
        'componentType' => 'componentType',
        'details'       => 'details',
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
        if (null !== $this->details) {
            $res['details'] = [];
            if (null !== $this->details && \is_array($this->details)) {
                $n = 0;
                foreach ($this->details as $item) {
                    $res['details'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['details'])) {
            if (!empty($map['details'])) {
                $model->details = [];
                $n              = 0;
                foreach ($map['details'] as $item) {
                    $model->details[$n++] = null !== $item ? details::fromMap($item) : $item;
                }
            }
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
