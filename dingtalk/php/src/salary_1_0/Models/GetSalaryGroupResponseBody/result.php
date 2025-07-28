<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\GetSalaryGroupResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $enableFlag;

    /**
     * @example SalaryItemGroupIdxxx
     *
     * @var string
     */
    public $salaryGroupId;

    /**
     * @example 123
     *
     * @var string
     */
    public $salaryGroupName;
    protected $_name = [
        'enableFlag' => 'enableFlag',
        'salaryGroupId' => 'salaryGroupId',
        'salaryGroupName' => 'salaryGroupName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enableFlag) {
            $res['enableFlag'] = $this->enableFlag;
        }
        if (null !== $this->salaryGroupId) {
            $res['salaryGroupId'] = $this->salaryGroupId;
        }
        if (null !== $this->salaryGroupName) {
            $res['salaryGroupName'] = $this->salaryGroupName;
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
        if (isset($map['enableFlag'])) {
            $model->enableFlag = $map['enableFlag'];
        }
        if (isset($map['salaryGroupId'])) {
            $model->salaryGroupId = $map['salaryGroupId'];
        }
        if (isset($map['salaryGroupName'])) {
            $model->salaryGroupName = $map['salaryGroupName'];
        }

        return $model;
    }
}
