<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class MoveDentryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $targetSpaceId;

    /**
     * @var string
     */
    public $toNextDentryId;

    /**
     * @var string
     */
    public $toParentDentryId;

    /**
     * @var string
     */
    public $toPrevDentryId;
    protected $_name = [
        'operatorId' => 'operatorId',
        'targetSpaceId' => 'targetSpaceId',
        'toNextDentryId' => 'toNextDentryId',
        'toParentDentryId' => 'toParentDentryId',
        'toPrevDentryId' => 'toPrevDentryId',
    ];

    public function validate() {}

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
