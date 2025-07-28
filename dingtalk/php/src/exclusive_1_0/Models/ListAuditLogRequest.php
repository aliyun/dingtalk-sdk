<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAuditLogRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1577945731837
     *
     * @var int
     */
    public $endDate;

    /**
     * @example 6406817113
     *
     * @var int
     */
    public $nextBizId;

    /**
     * @example 1577340931837
     *
     * @var int
     */
    public $nextGmtCreate;

    /**
     * @description This parameter is required.
     *
     * @example 500
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example 1577340931837
     *
     * @var int
     */
    public $startDate;
    protected $_name = [
        'endDate' => 'endDate',
        'nextBizId' => 'nextBizId',
        'nextGmtCreate' => 'nextGmtCreate',
        'pageSize' => 'pageSize',
        'startDate' => 'startDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->nextBizId) {
            $res['nextBizId'] = $this->nextBizId;
        }
        if (null !== $this->nextGmtCreate) {
            $res['nextGmtCreate'] = $this->nextGmtCreate;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAuditLogRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['nextBizId'])) {
            $model->nextBizId = $map['nextBizId'];
        }
        if (isset($map['nextGmtCreate'])) {
            $model->nextGmtCreate = $map['nextGmtCreate'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }

        return $model;
    }
}
