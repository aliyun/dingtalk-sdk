<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumUpdateProcessInstanceVariablesRequest;

use AlibabaCloud\Tea\Model;

class variables extends Model
{
    /**
     * @example Phone
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @example 总个数:1
     *
     * @var string
     */
    public $extValue;

    /**
     * @description This parameter is required.
     *
     * @example PhoneField_IZI2LP8QF6O0
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 123xxxxxxxx
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'bizAlias' => 'bizAlias',
        'extValue' => 'extValue',
        'id'       => 'id',
        'value'    => 'value',
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
        if (null !== $this->extValue) {
            $res['extValue'] = $this->extValue;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return variables
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['extValue'])) {
            $model->extValue = $map['extValue'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
