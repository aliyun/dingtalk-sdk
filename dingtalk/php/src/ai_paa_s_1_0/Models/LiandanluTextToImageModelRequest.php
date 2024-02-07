<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_paa_s_1_0\Models;

use AlibabaCloud\Tea\Model;

class LiandanluTextToImageModelRequest extends Model
{
    /**
     * @example IMAGE
     *
     * @var string
     */
    public $module;

    /**
     * @example 1
     *
     * @var int
     */
    public $number;

    /**
     * @var string[]
     */
    public $parameters;

    /**
     * @example 画一副风景画
     *
     * @var string
     */
    public $prompt;

    /**
     * @example 1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'module'     => 'module',
        'number'     => 'number',
        'parameters' => 'parameters',
        'prompt'     => 'prompt',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->module) {
            $res['module'] = $this->module;
        }
        if (null !== $this->number) {
            $res['number'] = $this->number;
        }
        if (null !== $this->parameters) {
            $res['parameters'] = $this->parameters;
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
     * @return LiandanluTextToImageModelRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['module'])) {
            $model->module = $map['module'];
        }
        if (isset($map['number'])) {
            $model->number = $map['number'];
        }
        if (isset($map['parameters'])) {
            $model->parameters = $map['parameters'];
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
