<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class UploadContractReviewByUrlRequest extends Model
{
    /**
     * @var string
     */
    public $fileUrl;

    /**
     * @var string
     */
    public $filename;

    /**
     * @var string
     */
    public $sessionId;
    protected $_name = [
        'fileUrl' => 'file_url',
        'filename' => 'filename',
        'sessionId' => 'session_id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileUrl) {
            $res['file_url'] = $this->fileUrl;
        }
        if (null !== $this->filename) {
            $res['filename'] = $this->filename;
        }
        if (null !== $this->sessionId) {
            $res['session_id'] = $this->sessionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UploadContractReviewByUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['file_url'])) {
            $model->fileUrl = $map['file_url'];
        }
        if (isset($map['filename'])) {
            $model->filename = $map['filename'];
        }
        if (isset($map['session_id'])) {
            $model->sessionId = $map['session_id'];
        }

        return $model;
    }
}
