<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmProcessRegularRequest extends Model
{
    /**
     * @description 操作人用户ID
     *
     * @var string
     */
    public $operationId;

    /**
     * @description 转正时间
     *
     * @var int
     */
    public $regularDate;

    /**
     * @description 备注
     *
     * @var string
     */
    public $remark;

    /**
     * @description 用户ID
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
