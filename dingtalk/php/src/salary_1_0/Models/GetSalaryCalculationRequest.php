<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSalaryCalculationRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2025-06
     *
     * @var string
     */
    public $date;

    /**
     * @description This parameter is required.
     *
     * @example SalaryGroupxxx
     *
     * @var string
     */
    public $salaryGroupId;
    protected $_name = [
        'date' => 'date',
        'salaryGroupId' => 'salaryGroupId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->salaryGroupId) {
            $res['salaryGroupId'] = $this->salaryGroupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSalaryCalculationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['salaryGroupId'])) {
            $model->salaryGroupId = $map['salaryGroupId'];
        }

        return $model;
    }
}
