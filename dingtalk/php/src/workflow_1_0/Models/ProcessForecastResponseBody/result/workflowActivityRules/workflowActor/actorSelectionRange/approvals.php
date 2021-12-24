<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActivityRules\workflowActor\actorSelectionRange;

use AlibabaCloud\Tea\Model;

class approvals extends Model
{
    /**
     * @description 员工 userId
     *
     * @var string
     */
    public $workNo;

    /**
     * @description 员工姓名
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'workNo'   => 'workNo',
        'userName' => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
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
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
