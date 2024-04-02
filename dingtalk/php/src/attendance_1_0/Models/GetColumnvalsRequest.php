<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetColumnvalsRequest extends Model
{
    /**
     * @var string[]
     */
    public $columnIdList;

    /**
     * @example 1709222400000
     *
     * @var int
     */
    public $fromDate;

    /**
     * @example 1711728000000
     *
     * @var int
     */
    public $toDate;

    /**
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'columnIdList' => 'columnIdList',
        'fromDate'     => 'fromDate',
        'toDate'       => 'toDate',
        'userIds'      => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->columnIdList) {
            $res['columnIdList'] = $this->columnIdList;
        }
        if (null !== $this->fromDate) {
            $res['fromDate'] = $this->fromDate;
        }
        if (null !== $this->toDate) {
            $res['toDate'] = $this->toDate;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetColumnvalsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['columnIdList'])) {
            if (!empty($map['columnIdList'])) {
                $model->columnIdList = $map['columnIdList'];
            }
        }
        if (isset($map['fromDate'])) {
            $model->fromDate = $map['fromDate'];
        }
        if (isset($map['toDate'])) {
            $model->toDate = $map['toDate'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
