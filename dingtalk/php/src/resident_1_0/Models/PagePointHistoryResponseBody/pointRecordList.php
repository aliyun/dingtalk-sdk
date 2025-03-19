<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\PagePointHistoryResponseBody;

use AlibabaCloud\Tea\Model;

class pointRecordList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1634630147
     *
     * @var int
     */
    public $createAt;

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
     * @example 123
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @example 7653
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'createAt' => 'createAt',
        'ruleCode' => 'ruleCode',
        'ruleName' => 'ruleName',
        'score' => 'score',
        'userId' => 'userId',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
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
     * @return pointRecordList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
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
