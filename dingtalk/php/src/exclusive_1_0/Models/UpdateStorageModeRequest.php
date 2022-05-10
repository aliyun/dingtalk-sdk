<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateStorageModeRequest extends Model
{
    /**
     * @description 专属文件跨云存储类型 0：公有模式，1：私有模式，注意，如不更新，则不填写这个字段，字段一旦有值，都会触发原有配置的删除
     *
     * @var string
     */
    public $fileStorageMode;

    /**
     * @description 企业id
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'fileStorageMode' => 'fileStorageMode',
        'targetCorpId'    => 'targetCorpId',
    ];

    public function validate()
    {
    }

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
