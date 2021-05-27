<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileUploadUrlRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $contentMd5;

    /**
     * @var string
     */
    public $contentType;

    /**
     * @var string
     */
    public $fileName;

    /**
     * @var int
     */
    public $fileSize;

    /**
     * @var bool
     */
    public $convert2Pdf;
    protected $_name = [
        'dingCorpId'  => 'dingCorpId',
        'contentMd5'  => 'contentMd5',
        'contentType' => 'contentType',
        'fileName'    => 'fileName',
        'fileSize'    => 'fileSize',
        'convert2Pdf' => 'convert2Pdf',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->contentMd5) {
            $res['contentMd5'] = $this->contentMd5;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->convert2Pdf) {
            $res['convert2Pdf'] = $this->convert2Pdf;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileUploadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['contentMd5'])) {
            $model->contentMd5 = $map['contentMd5'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['convert2Pdf'])) {
            $model->convert2Pdf = $map['convert2Pdf'];
        }

        return $model;
    }
}
