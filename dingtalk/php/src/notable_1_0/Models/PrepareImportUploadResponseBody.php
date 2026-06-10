<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrepareImportUploadResponseBody extends Model
{
    /**
     * @var int
     */
    public $expireAt;

    /**
     * @var string
     */
    public $importId;

    /**
     * @var string
     */
    public $uploadUrl;
    protected $_name = [
        'expireAt' => 'expireAt',
        'importId' => 'importId',
        'uploadUrl' => 'uploadUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->expireAt) {
            $res['expireAt'] = $this->expireAt;
        }
        if (null !== $this->importId) {
            $res['importId'] = $this->importId;
        }
        if (null !== $this->uploadUrl) {
            $res['uploadUrl'] = $this->uploadUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrepareImportUploadResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expireAt'])) {
            $model->expireAt = $map['expireAt'];
        }
        if (isset($map['importId'])) {
            $model->importId = $map['importId'];
        }
        if (isset($map['uploadUrl'])) {
            $model->uploadUrl = $map['uploadUrl'];
        }

        return $model;
    }
}
