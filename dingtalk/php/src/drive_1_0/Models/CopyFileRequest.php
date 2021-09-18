<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CopyFileRequest extends Model
{
    /**
     * @description 目标空间id
     *
     * @var string
     */
    public $targetSpaceId;

    /**
     * @description 目标父目录id
     *
     * @var string
     */
    public $targetParentId;

    /**
     * @description 文件名冲突策略
     *
     * @var string
     */
    public $addConflictPolicy;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'targetSpaceId'     => 'targetSpaceId',
        'targetParentId'    => 'targetParentId',
        'addConflictPolicy' => 'addConflictPolicy',
        'unionId'           => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetSpaceId) {
            $res['targetSpaceId'] = $this->targetSpaceId;
        }
        if (null !== $this->targetParentId) {
            $res['targetParentId'] = $this->targetParentId;
        }
        if (null !== $this->addConflictPolicy) {
            $res['addConflictPolicy'] = $this->addConflictPolicy;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetSpaceId'])) {
            $model->targetSpaceId = $map['targetSpaceId'];
        }
        if (isset($map['targetParentId'])) {
            $model->targetParentId = $map['targetParentId'];
        }
        if (isset($map['addConflictPolicy'])) {
            $model->addConflictPolicy = $map['addConflictPolicy'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
