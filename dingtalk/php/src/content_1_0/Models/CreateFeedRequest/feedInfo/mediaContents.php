<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\feedInfo;

use AlibabaCloud\Tea\Model;

class mediaContents extends Model
{
    /**
     * @description 媒体的类型，当前该接口只支持video和audio,2:视频,3:音频
     *
     * @var int
     */
    public $type;

    /**
     * @description 媒体的mediaId，唯一对应oss中的一个视频或者音频
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 媒体的标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'type'    => 'type',
        'mediaId' => 'mediaId',
        'title'   => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
     * @return mediaContents
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['type'])) {
            $model->type = $map['type'];
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
