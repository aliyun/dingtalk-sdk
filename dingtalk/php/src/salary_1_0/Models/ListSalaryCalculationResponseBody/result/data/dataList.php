<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\ListSalaryCalculationResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class dataList extends Model
{
    /**
     * @var string
     */
    public $salaryItemId;

    /**
     * @var string
     */
    public $salaryItemName;

    /**
     * @var string
     */
    public $salaryItemValue;
    protected $_name = [
        'salaryItemId' => 'salaryItemId',
        'salaryItemName' => 'salaryItemName',
        'salaryItemValue' => 'salaryItemValue',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->salaryItemId) {
            $res['salaryItemId'] = $this->salaryItemId;
        }
        if (null !== $this->salaryItemName) {
            $res['salaryItemName'] = $this->salaryItemName;
        }
        if (null !== $this->salaryItemValue) {
            $res['salaryItemValue'] = $this->salaryItemValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['salaryItemId'])) {
            $model->salaryItemId = $map['salaryItemId'];
        }
        if (isset($map['salaryItemName'])) {
            $model->salaryItemName = $map['salaryItemName'];
        }
        if (isset($map['salaryItemValue'])) {
            $model->salaryItemValue = $map['salaryItemValue'];
        }

        return $model;
    }
}
