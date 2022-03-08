<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListActionResponseBody\list_;

use AlibabaCloud\Tea\Model;

class actionContent extends Model
{
    /**
     * @description displayName
     *
     * @var string
     */
    public $displayName;

    /**
     * @description displayValue
     *
     * @var string
     */
    public $displayValue;

    /**
     * @description name
     *
     * @var string
     */
    public $name;

    /**
     * @description value
     *
     * @var string
     */
    public $value;

    /**
     * @description valueType
     *
     * @var string
     */
    public $valueType;
    protected $_name = [
        'displayName'  => 'displayName',
        'displayValue' => 'displayValue',
        'name'         => 'name',
        'value'        => 'value',
        'valueType'    => 'valueType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->displayValue) {
            $res['displayValue'] = $this->displayValue;
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
     * @return actionContent
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['displayValue'])) {
            $model->displayValue = $map['displayValue'];
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
