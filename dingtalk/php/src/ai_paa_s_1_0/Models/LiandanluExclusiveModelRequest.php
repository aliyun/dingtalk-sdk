<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class LiandanluExclusiveModelRequest extends Model
{
    /**
     * @example maas1234
     *
     * @var string
     */
    public $modelId;

    /**
     * @example GENERAL
     *
     * @var string
     */
    public $module;

    /**
     * @example OKR是什么
     *
     * @var string
     */
    public $prompt;

    /**
     * @example 使用该功能的用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'modelId' => 'modelId',
        'module'  => 'module',
        'prompt'  => 'prompt',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->module) {
            $res['module'] = $this->module;
        }
        if (null !== $this->prompt) {
            $res['prompt'] = $this->prompt;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LiandanluExclusiveModelRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['module'])) {
            $model->module = $map['module'];
        }
        if (isset($map['prompt'])) {
            $model->prompt = $map['prompt'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
