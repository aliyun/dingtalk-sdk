<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserAllLiveListRequest extends Model
{
    /**
     * @description 直播状态列表
     *
     * @var int[]
     */
    public $statuses;

    /**
     * @description 第几页，从1开始
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 单次拉去上限，默认40个
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 用户uid
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'statuses'   => 'statuses',
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
        if (null !== $this->statuses) {
            $res['statuses'] = $this->statuses;
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
     * @return GetUserAllLiveListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['statuses'])) {
            if (!empty($map['statuses'])) {
                $model->statuses = $map['statuses'];
            }
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
