<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\QueryAttachmentResponseBody;

use AlibabaCloud\Tea\Model;

class attachmentList extends Model
{
    /**
     * @var string
     */
    public $attachmentType;

    /**
     * @var string
     */
    public $downloadUrl;

    /**
     * @var string
     */
    public $fileName;

    /**
     * @var string
     */
    public $fileSize;

    /**
     * @var string
     */
    public $fileType;

    /**
     * @var string
     */
    public $location;
    protected $_name = [
        'attachmentType' => 'attachmentType',
        'downloadUrl' => 'downloadUrl',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileType' => 'fileType',
        'location' => 'location',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentType) {
            $res['attachmentType'] = $this->attachmentType;
        }
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->location) {
            $res['location'] = $this->location;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachmentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentType'])) {
            $model->attachmentType = $map['attachmentType'];
        }
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['location'])) {
            $model->location = $map['location'];
        }

        return $model;
    }
}
