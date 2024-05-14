<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetLeaveRecordsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example f84a2dxxxx
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description This parameter is required.
     *
     * @example user01
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description This parameter is required.
     *
     * @example 10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'leaveCode'  => 'leaveCode',
        'opUserId'   => 'opUserId',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'userIds'    => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->leaveCode) {
            $res['leaveCode'] = $this->leaveCode;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetLeaveRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['leaveCode'])) {
            $model->leaveCode = $map['leaveCode'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
