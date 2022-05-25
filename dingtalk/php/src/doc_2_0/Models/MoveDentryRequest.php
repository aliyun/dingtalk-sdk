<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class MoveDentryRequest extends Model
{
    /**
     * @description 操作人unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 需要移动到的知识库id。
     *
     * @var string
     */
    public $targetSpaceId;

    /**
     * @description 移动到目标位置的后置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
     *
     * @var string
     */
    public $toNextDentryId;

    /**
     * @description 需要移动到目标位置的父节点id。如果为根目录，则不传；如果为非根目录，则需要传对应的id。
     *
     * @var string
     */
    public $toParentDentryId;

    /**
     * @description 移动到目标位置的前置节点id。不为空时，需要是归属于 toParentDentryId 的子节点。
     *
     * @var string
     */
    public $toPrevDentryId;
    protected $_name = [
        'operatorId'       => 'operatorId',
        'targetSpaceId'    => 'targetSpaceId',
        'toNextDentryId'   => 'toNextDentryId',
        'toParentDentryId' => 'toParentDentryId',
        'toPrevDentryId'   => 'toPrevDentryId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->targetSpaceId) {
            $res['targetSpaceId'] = $this->targetSpaceId;
        }
        if (null !== $this->toNextDentryId) {
            $res['toNextDentryId'] = $this->toNextDentryId;
        }
        if (null !== $this->toParentDentryId) {
            $res['toParentDentryId'] = $this->toParentDentryId;
        }
        if (null !== $this->toPrevDentryId) {
            $res['toPrevDentryId'] = $this->toPrevDentryId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MoveDentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['targetSpaceId'])) {
            $model->targetSpaceId = $map['targetSpaceId'];
        }
        if (isset($map['toNextDentryId'])) {
            $model->toNextDentryId = $map['toNextDentryId'];
        }
        if (isset($map['toParentDentryId'])) {
            $model->toParentDentryId = $map['toParentDentryId'];
        }
        if (isset($map['toPrevDentryId'])) {
            $model->toPrevDentryId = $map['toPrevDentryId'];
        }

        return $model;
    }
}
