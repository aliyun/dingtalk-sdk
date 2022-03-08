<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddPointRequest extends Model
{
    /**
     * @description 增加积分的时间戳毫秒数，如果为空使用系统当前毫秒数
     *
     * @var int
     */
    public $actionTime;

    /**
     * @description 是否查询全员圈积分
     *
     * @var bool
     */
    public $isCircle;

    /**
     * @description 规则代码（可空）,如果不为空的话，score值使用ruleCode对应的score增加分数
     *
     * @var string
     */
    public $ruleCode;

    /**
     * @description 规则名字
     *
     * @var string
     */
    public $ruleName;

    /**
     * @description 本次增加积分：正数表示增加/负数表示扣减
     *
     * @var int
     */
    public $score;

    /**
     * @description 成员id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 加积分的唯一幂等标志
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
