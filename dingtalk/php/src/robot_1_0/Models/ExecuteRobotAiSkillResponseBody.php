<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecuteRobotAiSkillResponseBody extends Model
{
    /**
     * @var string
     */
    public $result;

    /**
     * @var string
     */
    public $skillExecuteId;
    protected $_name = [
        'result' => 'result',
        'skillExecuteId' => 'skillExecuteId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->skillExecuteId) {
            $res['skillExecuteId'] = $this->skillExecuteId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteRobotAiSkillResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['skillExecuteId'])) {
            $model->skillExecuteId = $map['skillExecuteId'];
        }

        return $model;
    }
}
