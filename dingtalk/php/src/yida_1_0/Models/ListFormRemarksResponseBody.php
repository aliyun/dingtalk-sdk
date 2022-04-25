<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListFormRemarksResponseBody extends Model
{
    /**
     * @description formRemarkVoMap
     *
     * @var mixed[]
     */
    public $formRemarkVoMap;
    protected $_name = [
        'formRemarkVoMap' => 'formRemarkVoMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formRemarkVoMap) {
            $res['formRemarkVoMap'] = $this->formRemarkVoMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFormRemarksResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formRemarkVoMap'])) {
            $model->formRemarkVoMap = $map['formRemarkVoMap'];
        }

        return $model;
    }
}
