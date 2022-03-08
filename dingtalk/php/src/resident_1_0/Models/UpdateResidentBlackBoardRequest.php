<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateResidentBlackBoardRequest extends Model
{
    /**
     * @var string
     */
    public $blackboardId;

    /**
     * @var string
     */
    public $context;

    /**
     * @var string
     */
    public $mediaId;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'blackboardId' => 'blackboardId',
        'context'      => 'context',
        'mediaId'      => 'mediaId',
        'title'        => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blackboardId) {
            $res['blackboardId'] = $this->blackboardId;
        }
        if (null !== $this->context) {
            $res['context'] = $this->context;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidentBlackBoardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blackboardId'])) {
            $model->blackboardId = $map['blackboardId'];
        }
        if (isset($map['context'])) {
            $model->context = $map['context'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
