<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateResidentBlackBoardRequest extends Model
{
    /**
     * @var string
     */
    public $context;

    /**
     * @var string
     */
    public $mediaId;

    /**
     * @description 格式yyyy-MM-dd HH:mm:ss
     *
     * @var string
     */
    public $sendTime;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'context'  => 'context',
        'mediaId'  => 'mediaId',
        'sendTime' => 'sendTime',
        'title'    => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->context) {
            $res['context'] = $this->context;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->sendTime) {
            $res['sendTime'] = $this->sendTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateResidentBlackBoardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['context'])) {
            $model->context = $map['context'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['sendTime'])) {
            $model->sendTime = $map['sendTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
