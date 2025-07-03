<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\WriteSalaryCalculationRequest\items;

use AlibabaCloud\Tea\Model;

class contents extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example SalaryItemXXX
     *
     * @var string
     */
    public $salaryItemId;

    /**
     * @example 26
     *
     * @var string
     */
    public $salaryItemValue;
    protected $_name = [
        'salaryItemId' => 'salaryItemId',
        'salaryItemValue' => 'salaryItemValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->salaryItemId) {
            $res['salaryItemId'] = $this->salaryItemId;
        }
        if (null !== $this->salaryItemValue) {
            $res['salaryItemValue'] = $this->salaryItemValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return contents
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['salaryItemId'])) {
            $model->salaryItemId = $map['salaryItemId'];
        }
        if (isset($map['salaryItemValue'])) {
            $model->salaryItemValue = $map['salaryItemValue'];
        }

        return $model;
    }
}
