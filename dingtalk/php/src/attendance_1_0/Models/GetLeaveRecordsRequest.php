<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetLeaveRecordsRequest extends Model
{
    /**
     * @description 假期类型唯一标识。
     *
     * @var string
     */
    public $leaveCode;

    /**
     * @description 操作人userId。
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 分页页码。
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小。
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 查询员工userId列表。一次最多支持50个。
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
