<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody\applyList;

use AlibabaCloud\Tea\Model;

class approverList extends Model
{
    /**
     * @description 审批备注
     *
     * @var string
     */
    public $note;

    /**
     * @description 审批时间
     *
     * @var string
     */
    public $operateTime;

    /**
     * @description 审批人排序值
     *
     * @var int
     */
    public $order;

    /**
     * @description 审批状态枚举：审批状态：0-审批中，1-已同意，2-已拒绝
     *
     * @var int
     */
    public $status;

    /**
     * @description 审批状态描述
     *
     * @var string
     */
    public $statusDesc;

    /**
     * @description 审批员工ID
     *
     * @var string
     */
    public $userId;

    /**
     * @description 审批员工名
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'note'        => 'note',
        'operateTime' => 'operateTime',
        'order'       => 'order',
        'status'      => 'status',
        'statusDesc'  => 'statusDesc',
        'userId'      => 'userId',
        'userName'    => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->operateTime) {
            $res['operateTime'] = $this->operateTime;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->statusDesc) {
            $res['statusDesc'] = $this->statusDesc;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return approverList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['operateTime'])) {
            $model->operateTime = $map['operateTime'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['statusDesc'])) {
            $model->statusDesc = $map['statusDesc'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
