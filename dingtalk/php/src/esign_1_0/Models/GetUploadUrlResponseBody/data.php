<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetUploadUrlResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $fileId;

    /**
     * @var string
     */
    public $uploadUrl;
    protected $_name = [
        'fileId'    => 'fileId',
        'uploadUrl' => 'uploadUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->uploadUrl) {
            $res['uploadUrl'] = $this->uploadUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['uploadUrl'])) {
            $model->uploadUrl = $map['uploadUrl'];
        }

        return $model;
    }
}
