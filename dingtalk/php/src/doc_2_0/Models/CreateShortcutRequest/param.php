<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\CreateShortcutRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dentryUuid
     *
     * @var string
     */
    public $sourceResourceId;

    /**
     * @description This parameter is required.
     *
     * @example DENTRY
     *
     * @var string
     */
    public $sourceResourceType;

    /**
     * @description This parameter is required.
     *
     * @example dentryUuid
     *
     * @var string
     */
    public $targetResourceId;

    /**
     * @example 123test
     *
     * @var string
     */
    public $targetResourceName;

    /**
     * @description This parameter is required.
     *
     * @example DENTRY
     *
     * @var string
     */
    public $targetResourceType;
    protected $_name = [
        'sourceResourceId' => 'sourceResourceId',
        'sourceResourceType' => 'sourceResourceType',
        'targetResourceId' => 'targetResourceId',
        'targetResourceName' => 'targetResourceName',
        'targetResourceType' => 'targetResourceType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sourceResourceId) {
            $res['sourceResourceId'] = $this->sourceResourceId;
        }
        if (null !== $this->sourceResourceType) {
            $res['sourceResourceType'] = $this->sourceResourceType;
        }
        if (null !== $this->targetResourceId) {
            $res['targetResourceId'] = $this->targetResourceId;
        }
        if (null !== $this->targetResourceName) {
            $res['targetResourceName'] = $this->targetResourceName;
        }
        if (null !== $this->targetResourceType) {
            $res['targetResourceType'] = $this->targetResourceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sourceResourceId'])) {
            $model->sourceResourceId = $map['sourceResourceId'];
        }
        if (isset($map['sourceResourceType'])) {
            $model->sourceResourceType = $map['sourceResourceType'];
        }
        if (isset($map['targetResourceId'])) {
            $model->targetResourceId = $map['targetResourceId'];
        }
        if (isset($map['targetResourceName'])) {
            $model->targetResourceName = $map['targetResourceName'];
        }
        if (isset($map['targetResourceType'])) {
            $model->targetResourceType = $map['targetResourceType'];
        }

        return $model;
    }
}
