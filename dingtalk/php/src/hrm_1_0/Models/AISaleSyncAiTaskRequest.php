<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AISaleSyncAiTaskRequest extends Model
{
    /**
     * @var string
     */
    public $scenarioCode;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userPrompt;

    /**
     * @var mixed[]
     */
    public $variables;
    protected $_name = [
        'scenarioCode' => 'scenarioCode',
        'userId' => 'userId',
        'userPrompt' => 'userPrompt',
        'variables' => 'variables',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->scenarioCode) {
            $res['scenarioCode'] = $this->scenarioCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userPrompt) {
            $res['userPrompt'] = $this->userPrompt;
        }
        if (null !== $this->variables) {
            $res['variables'] = $this->variables;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AISaleSyncAiTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scenarioCode'])) {
            $model->scenarioCode = $map['scenarioCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userPrompt'])) {
            $model->userPrompt = $map['userPrompt'];
        }
        if (isset($map['variables'])) {
            $model->variables = $map['variables'];
        }

        return $model;
    }
}
