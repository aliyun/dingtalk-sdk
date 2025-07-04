<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryItemResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example SalaryItemIdxxx
     *
     * @var string
     */
    public $salaryItemId;

    /**
     * @example 绩效xx
     *
     * @var string
     */
    public $salaryItemName;
    protected $_name = [
        'salaryItemId' => 'salaryItemId',
        'salaryItemName' => 'salaryItemName',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
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

        return $model;
    }
}
