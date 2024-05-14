<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class AttachmentsMapValue extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example upload_key
     *
     * @var string
     */
    public $uploadKey;

    /**
     * @description This parameter is required.
     *
     * @example name
     *
     * @var string
     */
    public $name;

    /**
     * @example media_type
     *
     * @var string
     */
    public $mediaType;
    protected $_name = [
        'uploadKey' => 'uploadKey',
        'name'      => 'name',
        'mediaType' => 'mediaType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->uploadKey) {
            $res['uploadKey'] = $this->uploadKey;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->mediaType) {
            $res['mediaType'] = $this->mediaType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AttachmentsMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['uploadKey'])) {
            $model->uploadKey = $map['uploadKey'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['mediaType'])) {
            $model->mediaType = $map['mediaType'];
        }

        return $model;
    }
}
