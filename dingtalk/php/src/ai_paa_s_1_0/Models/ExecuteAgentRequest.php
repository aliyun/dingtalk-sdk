<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models\ExecuteAgentRequest\inputs;
use AlibabaCloud\Tea\Model;

class ExecuteAgentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $agentCode;

    /**
     * @description This parameter is required.
     *
     * @var inputs
     */
    public $inputs;

    /**
     * @var string
     */
    public $scenarioCode;

    /**
     * @var string
     */
    public $scenarioInstanceId;

    /**
     * @var string
     */
    public $skillId;
    protected $_name = [
        'agentCode'          => 'agentCode',
        'inputs'             => 'inputs',
        'scenarioCode'       => 'scenarioCode',
        'scenarioInstanceId' => 'scenarioInstanceId',
        'skillId'            => 'skillId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentCode) {
            $res['agentCode'] = $this->agentCode;
        }
        if (null !== $this->inputs) {
            $res['inputs'] = null !== $this->inputs ? $this->inputs->toMap() : null;
        }
        if (null !== $this->scenarioCode) {
            $res['scenarioCode'] = $this->scenarioCode;
        }
        if (null !== $this->scenarioInstanceId) {
            $res['scenarioInstanceId'] = $this->scenarioInstanceId;
        }
        if (null !== $this->skillId) {
            $res['skillId'] = $this->skillId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExecuteAgentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentCode'])) {
            $model->agentCode = $map['agentCode'];
        }
        if (isset($map['inputs'])) {
            $model->inputs = inputs::fromMap($map['inputs']);
        }
        if (isset($map['scenarioCode'])) {
            $model->scenarioCode = $map['scenarioCode'];
        }
        if (isset($map['scenarioInstanceId'])) {
            $model->scenarioInstanceId = $map['scenarioInstanceId'];
        }
        if (isset($map['skillId'])) {
            $model->skillId = $map['skillId'];
        }

        return $model;
    }
}
