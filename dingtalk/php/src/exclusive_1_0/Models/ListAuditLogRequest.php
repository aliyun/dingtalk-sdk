<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAuditLogRequest extends Model
{
    /**
     * @description 操作日志截止时间，unix时间戳，单位ms
     *
     * @var int
     */
    public $endDate;

    /**
     * @description 操作记录文件id，作为分页偏移量，与nextGmtCreate一起使用，返回记录的bizId为nextBizId且gmtCreate为nextGmtCreate之后的操作列表，分页查询获取下一页时，传最后一条记录的bizId和gmtCreate。
     *
     * @var int
     */
    public $nextBizId;

    /**
     * @description 操作记录生成时间，作为分页偏移量，分页查询时必传，unix时间戳，单位ms
     *
     * @var int
     */
    public $nextGmtCreate;

    /**
     * @description 操作列表长度，最大500
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 操作日志起始时间，unix时间戳，单位ms
     *
     * @var int
     */
    public $startDate;
    protected $_name = [
        'endDate'       => 'endDate',
        'nextBizId'     => 'nextBizId',
        'nextGmtCreate' => 'nextGmtCreate',
        'pageSize'      => 'pageSize',
        'startDate'     => 'startDate',
    ];

    public function validate()
    {
    }

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
