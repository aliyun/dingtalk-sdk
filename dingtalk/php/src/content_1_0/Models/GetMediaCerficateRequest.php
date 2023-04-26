<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMediaCerficateRequest extends Model
{
    /**
     * @example D:\****.mp4
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 87712****6723412
     *
     * @var string
     */
    public $mcnId;

    /**
     * @example cd8b21090b6*********b78fa733
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example 视频描述。  长度不超过1024个字符。 UTF-8编码。
     *
     * @var string
     */
    public $mediaIntroduction;

    /**
     * @example UploadTest
     *
     * @var string
     */
    public $mediaTitle;

    /**
     * @example https://*****test.cn/image/D22F553*****TEST.jpeg
     *
     * @var string
     */
    public $thumbUrl;

    /**
     * @example edb2*****1090b66
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'fileName'          => 'fileName',
        'mcnId'             => 'mcnId',
        'mediaId'           => 'mediaId',
        'mediaIntroduction' => 'mediaIntroduction',
        'mediaTitle'        => 'mediaTitle',
        'thumbUrl'          => 'thumbUrl',
        'userId'            => 'userId',
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
        if (null !== $this->mcnId) {
            $res['mcnId'] = $this->mcnId;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->mediaIntroduction) {
            $res['mediaIntroduction'] = $this->mediaIntroduction;
        }
        if (null !== $this->mediaTitle) {
            $res['mediaTitle'] = $this->mediaTitle;
        }
        if (null !== $this->thumbUrl) {
            $res['thumbUrl'] = $this->thumbUrl;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMediaCerficateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['mcnId'])) {
            $model->mcnId = $map['mcnId'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['mediaIntroduction'])) {
            $model->mediaIntroduction = $map['mediaIntroduction'];
        }
        if (isset($map['mediaTitle'])) {
            $model->mediaTitle = $map['mediaTitle'];
        }
        if (isset($map['thumbUrl'])) {
            $model->thumbUrl = $map['thumbUrl'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
