<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUploadUrlRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contentMd5;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contentType;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $convert2Pdf;

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
    protected $_name = [
        'contentMd5'  => 'contentMd5',
        'contentType' => 'contentType',
        'convert2Pdf' => 'convert2Pdf',
        'fileName'    => 'fileName',
        'fileSize'    => 'fileSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentMd5) {
            $res['contentMd5'] = $this->contentMd5;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->convert2Pdf) {
            $res['convert2Pdf'] = $this->convert2Pdf;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUploadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentMd5'])) {
            $model->contentMd5 = $map['contentMd5'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['convert2Pdf'])) {
            $model->convert2Pdf = $map['convert2Pdf'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }

        return $model;
    }
}
