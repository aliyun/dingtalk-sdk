<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateKROfScoreRequest extends Model
{
    /**
     * @description 分数值。
     *
     * @var int
     */
    public $score;

    /**
     * @description 当前 KR ID。
     *
     * @var string
     */
    public $krId;

    /**
     * @description 当前用户的userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'score'  => 'score',
        'krId'   => 'krId',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->krId) {
            $res['krId'] = $this->krId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateKROfScoreRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['krId'])) {
            $model->krId = $map['krId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
