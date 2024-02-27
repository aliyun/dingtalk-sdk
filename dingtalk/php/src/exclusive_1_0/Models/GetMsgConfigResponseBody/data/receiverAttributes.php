<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data;

use AlibabaCloud\Tea\Model;

class receiverAttributes extends Model
{
    /**
     * @var string
     */
    public $employeeCode;
    protected $_name = [
        'employeeCode' => 'employeeCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->employeeCode) {
            $res['employeeCode'] = $this->employeeCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return receiverAttributes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['employeeCode'])) {
            $model->employeeCode = $map['employeeCode'];
        }

        return $model;
    }
}
