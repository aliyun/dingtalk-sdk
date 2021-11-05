<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListPointRulesResponseBody;

use AlibabaCloud\Tea\Model;

class pointRuleList extends Model
{
    /**
     * @description 组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 增加或减少的分数（增加为正数，减少为负数）
     *
     * @var int
     */
    public $score;

    /**
     * @description 单日计次上限，0表示无上限
     *
     * @var int
     */
    public $dayLimitTimes;

    /**
     * @description 生效状态 0：不生效，1：生效
     *
     * @var int
     */
    public $status;

    /**
     * @description 对应的行为代码（可空）
     *
     * @var string
     */
    public $ruleCode;

    /**
     * @description 对应的行为名字
     *
     * @var string
     */
    public $ruleName;

    /**
     * @description 扩展字段
     *
     * @var string
     */
    public $extension;

    /**
     * @description 分组ID, 默认写入为0
     *
     * @var int
     */
    public $groupId;

    /**
     * @description 排序ID
     *
     * @var int
     */
    public $orderId;
    protected $_name = [
        'corpId'        => 'corpId',
        'score'         => 'score',
        'dayLimitTimes' => 'dayLimitTimes',
        'status'        => 'status',
        'ruleCode'      => 'ruleCode',
        'ruleName'      => 'ruleName',
        'extension'     => 'extension',
        'groupId'       => 'groupId',
        'orderId'       => 'orderId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->dayLimitTimes) {
            $res['dayLimitTimes'] = $this->dayLimitTimes;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->ruleCode) {
            $res['ruleCode'] = $this->ruleCode;
        }
        if (null !== $this->ruleName) {
            $res['ruleName'] = $this->ruleName;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['dayLimitTimes'])) {
            $model->dayLimitTimes = $map['dayLimitTimes'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['ruleCode'])) {
            $model->ruleCode = $map['ruleCode'];
        }
        if (isset($map['ruleName'])) {
            $model->ruleName = $map['ruleName'];
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

        return $model;
    }
}
