<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data\groupAttributes;

use AlibabaCloud\Tea\Model;

class listReceiver extends Model
{
    /**
     * @var string
     */
    public $employeeCode;

    /**
     * @var string
     */
    public $employeeName;
    protected $_name = [
        'employeeCode' => 'employeeCode',
        'employeeName' => 'employeeName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->employeeCode) {
            $res['employeeCode'] = $this->employeeCode;
        }
        if (null !== $this->employeeName) {
            $res['employeeName'] = $this->employeeName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return listReceiver
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['employeeCode'])) {
            $model->employeeCode = $map['employeeCode'];
        }
        if (isset($map['employeeName'])) {
            $model->employeeName = $map['employeeName'];
        }

        return $model;
    }
}
