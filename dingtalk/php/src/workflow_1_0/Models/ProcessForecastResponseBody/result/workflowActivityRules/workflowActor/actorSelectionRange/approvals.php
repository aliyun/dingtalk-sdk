<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor\actorSelectionRange;

use AlibabaCloud\Tea\Model;

class approvals extends Model
{
    /**
     * @description 员工姓名
     *
     * @var string
     */
    public $userName;

    /**
     * @description 员工 userId
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'userName' => 'userName',
        'workNo'   => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return approvals
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
