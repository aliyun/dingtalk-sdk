<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\GetCardInfoResponseBody\extension\cardContactInfo;

use AlibabaCloud\Tea\Model;

class workPhone extends Model
{
    /**
     * @var string
     */
    public $label;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'label' => 'label',
        'value' => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return workPhone
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
