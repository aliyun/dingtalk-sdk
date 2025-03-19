<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class extFormComponent extends Model
{
    /**
     * @example ""
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @example MoneyField
     *
     * @var string
     */
    public $componentType;

    /**
     * @example "{\"upper\":\"玖元玖角玖分\",\"componentName\":\"MoneyField\"}"
     *
     * @var string
     */
    public $extValue;

    /**
     * @example MoneyField_18PDM5K773FK0
     *
     * @var string
     */
    public $id;

    /**
     * @example 预估金额
     *
     * @var string
     */
    public $name;

    /**
     * @example 9.99
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'bizAlias' => 'bizAlias',
        'componentType' => 'componentType',
        'extValue' => 'extValue',
        'id' => 'id',
        'name' => 'name',
        'value' => 'value',
    ];

    public function validate() {}

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
     * @return extFormComponent
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
