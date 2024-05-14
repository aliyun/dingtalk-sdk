<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateBadgeNotifyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $content;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $msgId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $msgType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'content' => 'content',
        'msgId'   => 'msgId',
        'msgType' => 'msgType',
        'userId'  => 'userId',
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
        if (null !== $this->msgId) {
            $res['msgId'] = $this->msgId;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateBadgeNotifyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['msgId'])) {
            $model->msgId = $map['msgId'];
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
