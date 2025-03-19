<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\TaskInfoCancelOrDelTaskRequest;

use AlibabaCloud\Tea\Model;

class taskExecutePersonDTOS extends Model
{
    /**
     * @var string
     */
    public $employeeCode;

    /**
     * @var int
     */
    public $personType;
    protected $_name = [
        'employeeCode' => 'employeeCode',
        'personType' => 'personType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->employeeCode) {
            $res['employeeCode'] = $this->employeeCode;
        }
        if (null !== $this->personType) {
            $res['personType'] = $this->personType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return taskExecutePersonDTOS
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['employeeCode'])) {
            $model->employeeCode = $map['employeeCode'];
        }
        if (isset($map['personType'])) {
            $model->personType = $map['personType'];
        }

        return $model;
    }
}
