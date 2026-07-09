<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class ImportCandidateByResumeRequest extends Model
{
    /**
     * @var string
     */
    public $channelCode;

    /**
     * @var string
     */
    public $fileId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileName;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $fileSourceType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileType;

    /**
     * @var int
     */
    public $spaceId;

    /**
     * @var string
     */
    public $url;

    /**
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'channelCode' => 'channelCode',
        'fileId' => 'fileId',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileSourceType' => 'fileSourceType',
        'fileType' => 'fileType',
        'spaceId' => 'spaceId',
        'url' => 'url',
        'opUserId' => 'opUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileSourceType) {
            $res['fileSourceType'] = $this->fileSourceType;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ImportCandidateByResumeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileSourceType'])) {
            $model->fileSourceType = $map['fileSourceType'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
