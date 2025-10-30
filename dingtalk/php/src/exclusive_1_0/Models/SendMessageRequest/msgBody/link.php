<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest\msgBody;

use AlibabaCloud\Tea\Model;

class link extends Model
{
    /**
     * @example P16mHftLYX8iE
     *
     * @var string
     */
    public $coverImageMediaId;

    /**
     * @example https://dingtalk.com
     *
     * @var string
     */
    public $linkUrl;

    /**
     * @var int
     */
    public $openType;

    /**
     * @example 描述信息
     *
     * @var string
     */
    public $summary;

    /**
     * @example title
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'coverImageMediaId' => 'cover_image_media_id',
        'linkUrl' => 'link_url',
        'openType' => 'open_type',
        'summary' => 'summary',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->coverImageMediaId) {
            $res['cover_image_media_id'] = $this->coverImageMediaId;
        }
        if (null !== $this->linkUrl) {
            $res['link_url'] = $this->linkUrl;
        }
        if (null !== $this->openType) {
            $res['open_type'] = $this->openType;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return link
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cover_image_media_id'])) {
            $model->coverImageMediaId = $map['cover_image_media_id'];
        }
        if (isset($map['link_url'])) {
            $model->linkUrl = $map['link_url'];
        }
        if (isset($map['open_type'])) {
            $model->openType = $map['open_type'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
