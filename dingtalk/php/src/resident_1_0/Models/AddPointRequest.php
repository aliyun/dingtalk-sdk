<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddPointRequest extends Model
{
    /**
     * @example 1634630147
     *
     * @var int
     */
    public $actionTime;

    /**
     * @example false
     *
     * @var bool
     */
    public $isCircle;

    /**
     * @example rule_1
     *
     * @var string
     */
    public $ruleCode;

    /**
     * @example 发动态
     *
     * @var string
     */
    public $ruleName;

    /**
     * @example 3
     *
     * @var int
     */
    public $score;

    /**
     * @example 123
     *
     * @var string
     */
    public $userId;

    /**
     * @example 7645
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'actionTime' => 'actionTime',
        'isCircle'   => 'isCircle',
        'ruleCode'   => 'ruleCode',
        'ruleName'   => 'ruleName',
        'score'      => 'score',
        'userId'     => 'userId',
        'uuid'       => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionTime) {
            $res['actionTime'] = $this->actionTime;
        }
        if (null !== $this->isCircle) {
            $res['isCircle'] = $this->isCircle;
        }
        if (null !== $this->ruleCode) {
            $res['ruleCode'] = $this->ruleCode;
        }
        if (null !== $this->ruleName) {
            $res['ruleName'] = $this->ruleName;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddPointRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionTime'])) {
            $model->actionTime = $map['actionTime'];
        }
        if (isset($map['isCircle'])) {
            $model->isCircle = $map['isCircle'];
        }
        if (isset($map['ruleCode'])) {
            $model->ruleCode = $map['ruleCode'];
        }
        if (isset($map['ruleName'])) {
            $model->ruleName = $map['ruleName'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
