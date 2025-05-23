<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetFormInstanceResponseBody;

use AlibabaCloud\Tea\Model;

class formInstDataList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $componentType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $extendValue;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $key;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $label;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'bizAlias' => 'bizAlias',
        'componentType' => 'componentType',
        'extendValue' => 'extendValue',
        'key' => 'key',
        'label' => 'label',
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
        if (null !== $this->extendValue) {
            $res['extendValue'] = $this->extendValue;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return formInstDataList
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
        if (isset($map['extendValue'])) {
            $model->extendValue = $map['extendValue'];
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
