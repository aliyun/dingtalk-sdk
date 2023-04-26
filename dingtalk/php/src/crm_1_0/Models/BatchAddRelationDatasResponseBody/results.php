<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\BatchAddRelationDatasResponseBody;

use AlibabaCloud\Tea\Model;

class results extends Model
{
    /**
     * @var string[]
     */
    public $duplicatedRelationIds;

    /**
     * @example 1002
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example 查重失败
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @example gads1ag-sfgasdfxcvxb
     *
     * @var string
     */
    public $relationId;

    /**
     * @example true
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'duplicatedRelationIds' => 'duplicatedRelationIds',
        'errorCode'             => 'errorCode',
        'errorMsg'              => 'errorMsg',
        'relationId'            => 'relationId',
        'success'               => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->duplicatedRelationIds) {
            $res['duplicatedRelationIds'] = $this->duplicatedRelationIds;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return results
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['duplicatedRelationIds'])) {
            if (!empty($map['duplicatedRelationIds'])) {
                $model->duplicatedRelationIds = $map['duplicatedRelationIds'];
            }
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
