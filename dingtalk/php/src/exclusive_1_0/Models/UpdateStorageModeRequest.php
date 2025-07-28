<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateStorageModeRequest extends Model
{
    /**
     * @example 0
     *
     * @var string
     */
    public $fileStorageMode;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxxxxxxxxx
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'fileStorageMode' => 'fileStorageMode',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileStorageMode) {
            $res['fileStorageMode'] = $this->fileStorageMode;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateStorageModeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileStorageMode'])) {
            $model->fileStorageMode = $map['fileStorageMode'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
