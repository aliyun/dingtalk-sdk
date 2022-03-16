<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateObjectiveRequest extends Model
{
    /**
     * @description 创建Objective 的内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 当前周期 ID。
     *
     * @var string
     */
    public $periodId;

    /**
     * @description 上一个 Objective 的位置。
     *
     * @var string
     */
    public $prevPosition;

    /**
     * @description 当前用户的 userId。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'content'      => 'content',
        'periodId'     => 'periodId',
        'prevPosition' => 'prevPosition',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->prevPosition) {
            $res['prevPosition'] = $this->prevPosition;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateObjectiveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['prevPosition'])) {
            $model->prevPosition = $map['prevPosition'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
