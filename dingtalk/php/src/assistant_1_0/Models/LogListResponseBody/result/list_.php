<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\LogListResponseBody\result;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $actionNames;

    /**
     * @var string
     */
    public $customChannel;

    /**
     * @var string
     */
    public $input;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $output;

    /**
     * @var string
     */
    public $result;

    /**
     * @var string
     */
    public $scene;

    /**
     * @var int
     */
    public $time;

    /**
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'actionNames' => 'actionNames',
        'customChannel' => 'customChannel',
        'input' => 'input',
        'name' => 'name',
        'output' => 'output',
        'result' => 'result',
        'scene' => 'scene',
        'time' => 'time',
        'unionId' => 'unionId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionNames) {
            $res['actionNames'] = $this->actionNames;
        }
        if (null !== $this->customChannel) {
            $res['customChannel'] = $this->customChannel;
        }
        if (null !== $this->input) {
            $res['input'] = $this->input;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->output) {
            $res['output'] = $this->output;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionNames'])) {
            $model->actionNames = $map['actionNames'];
        }
        if (isset($map['customChannel'])) {
            $model->customChannel = $map['customChannel'];
        }
        if (isset($map['input'])) {
            $model->input = $map['input'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['output'])) {
            $model->output = $map['output'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
