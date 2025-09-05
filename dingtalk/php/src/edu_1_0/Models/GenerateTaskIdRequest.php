<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GenerateTaskIdRequest extends Model
{
    /**
     * @var int
     */
    public $maxTokens;

    /**
     * @description This parameter is required.
     *
     * @example qwen-max
     *
     * @var string
     */
    public $model;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $prompt;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $scene;

    /**
     * @var float
     */
    public $temperature;

    /**
     * @var float
     */
    public $topP;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'maxTokens' => 'maxTokens',
        'model' => 'model',
        'prompt' => 'prompt',
        'scene' => 'scene',
        'temperature' => 'temperature',
        'topP' => 'top_p',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxTokens) {
            $res['maxTokens'] = $this->maxTokens;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->prompt) {
            $res['prompt'] = $this->prompt;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->temperature) {
            $res['temperature'] = $this->temperature;
        }
        if (null !== $this->topP) {
            $res['top_p'] = $this->topP;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GenerateTaskIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxTokens'])) {
            $model->maxTokens = $map['maxTokens'];
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['prompt'])) {
            $model->prompt = $map['prompt'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['temperature'])) {
            $model->temperature = $map['temperature'];
        }
        if (isset($map['top_p'])) {
            $model->topP = $map['top_p'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
