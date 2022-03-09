<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;
use GuzzleHttp\Psr7\Stream;

class CreateObjectiveRequest extends Model
{
    /**
     * @description content
     *
     * @var Stream
     */
    public $content;

    /**
     * @description periodId
     *
     * @var Stream
     */
    public $periodId;

    /**
     * @description prevPosition
     *
     * @var Stream
     */
    public $prevPosition;

    /**
     * @description userId
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
