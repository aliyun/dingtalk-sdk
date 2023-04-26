<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody\applyList;

use AlibabaCloud\Tea\Model;

class approverList extends Model
{
    /**
     * @example 同意
     *
     * @var string
     */
    public $note;

    /**
     * @example 2021-03-18 20:26:56
     *
     * @var string
     */
    public $operateTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $order;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 同意
     *
     * @var string
     */
    public $statusDesc;

    /**
     * @example user1
     *
     * @var string
     */
    public $userId;

    /**
     * @example 员工1
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
