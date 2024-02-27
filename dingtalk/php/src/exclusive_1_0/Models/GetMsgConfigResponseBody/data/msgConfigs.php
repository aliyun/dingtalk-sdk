<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgConfigResponseBody\data;

use AlibabaCloud\Tea\Model;

class msgConfigs extends Model
{
    /**
     * @var string
     */
    public $cardId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $customParameters;

    /**
     * @var int
     */
    public $msgContentConsisFlag;

    /**
     * @var string
     */
    public $msgId;

    /**
     * @var string
     */
    public $robotCode;

    /**
     * @var string
     */
    public $ruleBusinessCode;

    /**
     * @var int
     */
    public $ruleCategory;

    /**
     * @var string
     */
    public $ruleCode;

    /**
     * @var string
     */
    public $ruleName;

    /**
     * @var string
     */
    public $subRuleCode;

    /**
     * @var string
     */
    public $systemCode;

    /**
     * @var string
     */
    public $taskBatchNo;
    protected $_name = [
        'cardId'               => 'cardId',
        'corpId'               => 'corpId',
        'customParameters'     => 'customParameters',
        'msgContentConsisFlag' => 'msgContentConsisFlag',
        'msgId'                => 'msgId',
        'robotCode'            => 'robotCode',
        'ruleBusinessCode'     => 'ruleBusinessCode',
        'ruleCategory'         => 'ruleCategory',
        'ruleCode'             => 'ruleCode',
        'ruleName'             => 'ruleName',
        'subRuleCode'          => 'subRuleCode',
        'systemCode'           => 'systemCode',
        'taskBatchNo'          => 'taskBatchNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardId) {
            $res['cardId'] = $this->cardId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->customParameters) {
            $res['customParameters'] = $this->customParameters;
        }
        if (null !== $this->msgContentConsisFlag) {
            $res['msgContentConsisFlag'] = $this->msgContentConsisFlag;
        }
        if (null !== $this->msgId) {
            $res['msgId'] = $this->msgId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->ruleBusinessCode) {
            $res['ruleBusinessCode'] = $this->ruleBusinessCode;
        }
        if (null !== $this->ruleCategory) {
            $res['ruleCategory'] = $this->ruleCategory;
        }
        if (null !== $this->ruleCode) {
            $res['ruleCode'] = $this->ruleCode;
        }
        if (null !== $this->ruleName) {
            $res['ruleName'] = $this->ruleName;
        }
        if (null !== $this->subRuleCode) {
            $res['subRuleCode'] = $this->subRuleCode;
        }
        if (null !== $this->systemCode) {
            $res['systemCode'] = $this->systemCode;
        }
        if (null !== $this->taskBatchNo) {
            $res['taskBatchNo'] = $this->taskBatchNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return msgConfigs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardId'])) {
            $model->cardId = $map['cardId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['customParameters'])) {
            $model->customParameters = $map['customParameters'];
        }
        if (isset($map['msgContentConsisFlag'])) {
            $model->msgContentConsisFlag = $map['msgContentConsisFlag'];
        }
        if (isset($map['msgId'])) {
            $model->msgId = $map['msgId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['ruleBusinessCode'])) {
            $model->ruleBusinessCode = $map['ruleBusinessCode'];
        }
        if (isset($map['ruleCategory'])) {
            $model->ruleCategory = $map['ruleCategory'];
        }
        if (isset($map['ruleCode'])) {
            $model->ruleCode = $map['ruleCode'];
        }
        if (isset($map['ruleName'])) {
            $model->ruleName = $map['ruleName'];
        }
        if (isset($map['subRuleCode'])) {
            $model->subRuleCode = $map['subRuleCode'];
        }
        if (isset($map['systemCode'])) {
            $model->systemCode = $map['systemCode'];
        }
        if (isset($map['taskBatchNo'])) {
            $model->taskBatchNo = $map['taskBatchNo'];
        }

        return $model;
    }
}
