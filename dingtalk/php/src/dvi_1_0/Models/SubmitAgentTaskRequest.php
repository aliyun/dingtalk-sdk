<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubmitAgentTaskRequest extends Model
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
     * @var string
     */
    public $bizIdentify;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $input;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'agentCode' => 'agentCode',
        'bizIdentify' => 'bizIdentify',
        'input' => 'input',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->agentCode) {
            $res['agentCode'] = $this->agentCode;
        }
        if (null !== $this->bizIdentify) {
            $res['bizIdentify'] = $this->bizIdentify;
        }
        if (null !== $this->input) {
            $res['input'] = $this->input;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitAgentTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['agentCode'])) {
            $model->agentCode = $map['agentCode'];
        }
        if (isset($map['bizIdentify'])) {
            $model->bizIdentify = $map['bizIdentify'];
        }
        if (isset($map['input'])) {
            $model->input = $map['input'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
