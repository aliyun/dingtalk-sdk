<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryLiveWatchUserListRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1a353547-040d-4095-bb93-404bc5d47920
     *
     * @var string
     */
    public $liveId;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example DC7wZGOSueEEIGOf3WKwWgiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'liveId'     => 'liveId',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryLiveWatchUserListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
