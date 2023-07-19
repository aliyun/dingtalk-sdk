<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExecuteRobotAiSkillRequest extends Model
{
    /**
     * @var mixed[]
     */
    public $context;

    /**
     * @var string
     */
    public $input;

    /**
     * @var string
     */
    public $robotCode;

    /**
     * @var string
     */
    public $skillId;
    protected $_name = [
        'context'   => 'context',
        'input'     => 'input',
        'robotCode' => 'robotCode',
        'skillId'   => 'skillId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->context) {
            $res['context'] = $this->context;
        }
        if (null !== $this->input) {
            $res['input'] = $this->input;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->skillId) {
            $res['skillId'] = $this->skillId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteRobotAiSkillRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['context'])) {
            $model->context = $map['context'];
        }
        if (isset($map['input'])) {
            $model->input = $map['input'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['skillId'])) {
            $model->skillId = $map['skillId'];
        }

        return $model;
    }
}
