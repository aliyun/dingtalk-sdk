<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\GetFamilySchoolConversationMsgResponseBody\messages;

use AlibabaCloud\Tea\Model;

class mediaModels extends Model
{
    /**
     * @example aa.png
     *
     * @var string
     */
    public $fileName;

    /**
     * @example png
     *
     * @var string
     */
    public $fileType;

    /**
     * @example @12xxx34
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example 1234
     *
     * @var string
     */
    public $size;

    /**
     * @example https://wukong-xxxx
     *
     * @var string
     */
    public $url;

    /**
     * @example @12xx34
     *
     * @var string
     */
    public $videoPicMediaId;
    protected $_name = [
        'fileName'        => 'fileName',
        'fileType'        => 'fileType',
        'mediaId'         => 'mediaId',
        'size'            => 'size',
        'url'             => 'url',
        'videoPicMediaId' => 'videoPicMediaId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->videoPicMediaId) {
            $res['videoPicMediaId'] = $this->videoPicMediaId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mediaModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['videoPicMediaId'])) {
            $model->videoPicMediaId = $map['videoPicMediaId'];
        }

        return $model;
    }
}
