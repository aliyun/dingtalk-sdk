<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmProcessRegularRequest extends Model
{
    /**
     * @example 16690147049882572
     *
     * @var string
     */
    public $operationId;

    /**
     * @example 1672542359000
     *
     * @var int
     */
    public $regularDate;

    /**
     * @example 同意转正
     *
     * @var string
     */
    public $remark;

    /**
     * @example 16690147049882572
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'operationId' => 'operationId',
        'regularDate' => 'regularDate',
        'remark'      => 'remark',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operationId) {
            $res['operationId'] = $this->operationId;
        }
        if (null !== $this->regularDate) {
            $res['regularDate'] = $this->regularDate;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmProcessRegularRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operationId'])) {
            $model->operationId = $map['operationId'];
        }
        if (isset($map['regularDate'])) {
            $model->regularDate = $map['regularDate'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
