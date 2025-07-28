<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListPointRulesResponseBody;

use AlibabaCloud\Tea\Model;

class pointRuleList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 50
     *
     * @var int
     */
    public $dayLimitTimes;

    /**
     * @description This parameter is required.
     *
     * @example text
     *
     * @var string
     */
    public $extension;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $groupId;

    /**
     * @description This parameter is required.
     *
     * @example 排序Id
     *
     * @var int
     */
    public $orderId;

    /**
     * @example rule_1
     *
     * @var string
     */
    public $ruleCode;

    /**
     * @description This parameter is required.
     *
     * @example 发动态
     *
     * @var string
     */
    public $ruleName;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var int
     */
    public $score;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'dayLimitTimes' => 'dayLimitTimes',
        'extension' => 'extension',
        'groupId' => 'groupId',
        'orderId' => 'orderId',
        'ruleCode' => 'ruleCode',
        'ruleName' => 'ruleName',
        'score' => 'score',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dayLimitTimes) {
            $res['dayLimitTimes'] = $this->dayLimitTimes;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return pointRuleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dayLimitTimes'])) {
            $model->dayLimitTimes = $map['dayLimitTimes'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
