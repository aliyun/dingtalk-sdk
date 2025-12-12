<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateMinutesByUploadFileRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description This parameter is required.
     *
     * @example https://media.source/audiotominutes.ogg
     *
     * @var string
     */
    public $mediaFileUrl;

    /**
     * @description This parameter is required.
     *
     * @example audio
     *
     * @var string
     */
    public $mediaType;

    /**
     * @description This parameter is required.
     *
     * @example 11-20 录音
     *
     * @var string
     */
    public $title;

    /**
     * @description This parameter is required.
     *
     * @example lJcRnm39OsU4jlFVmRGXXXXX
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bizId' => 'bizId',
        'creatorId' => 'creatorId',
        'mediaFileUrl' => 'mediaFileUrl',
        'mediaType' => 'mediaType',
        'title' => 'title',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->mediaFileUrl) {
            $res['mediaFileUrl'] = $this->mediaFileUrl;
        }
        if (null !== $this->mediaType) {
            $res['mediaType'] = $this->mediaType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMinutesByUploadFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['mediaFileUrl'])) {
            $model->mediaFileUrl = $map['mediaFileUrl'];
        }
        if (isset($map['mediaType'])) {
            $model->mediaType = $map['mediaType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
