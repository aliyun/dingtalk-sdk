<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\PagePointHistoryResponseBody;

use AlibabaCloud\Tea\Model;

class pointRecordList extends Model
{
    /**
     * @description 组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 成员id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 增加或减少的分数（增加为正数，减少为负数）
     *
     * @var int
     */
    public $score;

    /**
     * @description 创建时间（精确到毫秒数）
     *
     * @var int
     */
    public $createAt;

    /**
     * @description 幂等键
     *
     * @var string
     */
    public $uuid;

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
    protected $_name = [
        'corpId'   => 'corpId',
        'userId'   => 'userId',
        'score'    => 'score',
        'createAt' => 'createAt',
        'uuid'     => 'uuid',
        'ruleCode' => 'ruleCode',
        'ruleName' => 'ruleName',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->createAt) {
            $res['createAt'] = $this->createAt;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->ruleCode) {
            $res['ruleCode'] = $this->ruleCode;
        }
        if (null !== $this->ruleName) {
            $res['ruleName'] = $this->ruleName;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['createAt'])) {
            $model->createAt = $map['createAt'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['ruleCode'])) {
            $model->ruleCode = $map['ruleCode'];
        }
        if (isset($map['ruleName'])) {
            $model->ruleName = $map['ruleName'];
        }

        return $model;
    }
}
