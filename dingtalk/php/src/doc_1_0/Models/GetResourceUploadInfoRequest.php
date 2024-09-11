<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetResourceUploadInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $mediaType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $resourceName;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $size;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'mediaType'    => 'mediaType',
        'resourceName' => 'resourceName',
        'size'         => 'size',
        'operatorId'   => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaType) {
            $res['mediaType'] = $this->mediaType;
        }
        if (null !== $this->resourceName) {
            $res['resourceName'] = $this->resourceName;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResourceUploadInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaType'])) {
            $model->mediaType = $map['mediaType'];
        }
        if (isset($map['resourceName'])) {
            $model->resourceName = $map['resourceName'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
