<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetUserCreateLiveListRequest\statuses;
use AlibabaCloud\Tea\Model;

class GetUserCreateLiveListRequest extends Model
{
    /**
     * @description 分页游标 第一次可不填， 后面填回包的值
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 单次拉去上限，默认40个
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description post请求体, 开放平台建议以对象形式存储
     *
     * @var statuses
     */
    public $statuses;

    /**
     * @description 用户uid
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'nextToken' => 'nextToken',
        'pageSize'  => 'pageSize',
        'statuses'  => 'statuses',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->statuses) {
            $res['statuses'] = null !== $this->statuses ? $this->statuses->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserCreateLiveListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['statuses'])) {
            $model->statuses = statuses::fromMap($map['statuses']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
