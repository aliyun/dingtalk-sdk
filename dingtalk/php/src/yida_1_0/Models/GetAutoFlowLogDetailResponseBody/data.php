<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAutoFlowLogDetailResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $activityKey;

    /**
     * @var int
     */
    public $elapsedTimeGMT;

    /**
     * @example 2021-01-01
     *
     * @var string
     */
    public $finishTimeGMT;

    /**
     * @var string
     */
    public $flag;

    /**
     * @var mixed[]
     */
    public $inputParams;

    /**
     * @example 测试应用
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $others;

    /**
     * @var mixed[]
     */
    public $outputParams;

    /**
     * @example running
     *
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'activityKey' => 'activityKey',
        'elapsedTimeGMT' => 'elapsedTimeGMT',
        'finishTimeGMT' => 'finishTimeGMT',
        'flag' => 'flag',
        'inputParams' => 'inputParams',
        'name' => 'name',
        'others' => 'others',
        'outputParams' => 'outputParams',
        'status' => 'status',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityKey) {
            $res['activityKey'] = $this->activityKey;
        }
        if (null !== $this->elapsedTimeGMT) {
            $res['elapsedTimeGMT'] = $this->elapsedTimeGMT;
        }
        if (null !== $this->finishTimeGMT) {
            $res['finishTimeGMT'] = $this->finishTimeGMT;
        }
        if (null !== $this->flag) {
            $res['flag'] = $this->flag;
        }
        if (null !== $this->inputParams) {
            $res['inputParams'] = $this->inputParams;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->others) {
            $res['others'] = $this->others;
        }
        if (null !== $this->outputParams) {
            $res['outputParams'] = $this->outputParams;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityKey'])) {
            $model->activityKey = $map['activityKey'];
        }
        if (isset($map['elapsedTimeGMT'])) {
            $model->elapsedTimeGMT = $map['elapsedTimeGMT'];
        }
        if (isset($map['finishTimeGMT'])) {
            $model->finishTimeGMT = $map['finishTimeGMT'];
        }
        if (isset($map['flag'])) {
            $model->flag = $map['flag'];
        }
        if (isset($map['inputParams'])) {
            $model->inputParams = $map['inputParams'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['others'])) {
            $model->others = $map['others'];
        }
        if (isset($map['outputParams'])) {
            $model->outputParams = $map['outputParams'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
