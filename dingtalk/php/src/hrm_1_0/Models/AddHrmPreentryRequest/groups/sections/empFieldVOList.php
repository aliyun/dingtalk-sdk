<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AddHrmPreentryRequest\groups\sections;

use AlibabaCloud\Tea\Model;

class empFieldVOList extends Model
{
    /**
     * @var string
     */
    public $value;

    /**
     * @var string
     */
    public $fieldCode;
    protected $_name = [
        'value'     => 'value',
        'fieldCode' => 'fieldCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return empFieldVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }

        return $model;
    }
}
