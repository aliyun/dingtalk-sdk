<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo;

use AlibabaCloud\Tea\Model;

class mediaContents extends Model
{
    /**
     * @example 378a1a0154b34**********86313948e
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example 媒体标题
     *
     * @var string
     */
    public $title;

    /**
     * @example 2
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'mediaId' => 'mediaId',
        'title'   => 'title',
        'type'    => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mediaContents
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
