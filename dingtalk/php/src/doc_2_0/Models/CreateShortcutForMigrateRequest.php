<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class CreateShortcutForMigrateRequest extends Model
{
    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var string
     */
    public $sourceResourceId;

    /**
     * @var string
     */
    public $sourceResourceType;

    /**
     * @var string
     */
    public $targetResourceId;

    /**
     * @var string
     */
    public $targetResourceName;

    /**
     * @var string
     */
    public $targetResourceType;
    protected $_name = [
        'operatorId' => 'operatorId',
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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
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
     * @return CreateShortcutForMigrateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
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
