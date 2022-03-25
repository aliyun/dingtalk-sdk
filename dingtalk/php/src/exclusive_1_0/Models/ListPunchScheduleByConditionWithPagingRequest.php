<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListPunchScheduleByConditionWithPagingRequest extends Model
{
    /**
     * @description 业务实例id，在该接口中表示打卡机实例id
     *
     * @var string
     */
    public $bizInstanceId;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 游标位置
     *
     * @var int
     */
    public $nextToken;

    /**
     * @description 查询日期结束时间（yyyy-MM-dd)
     *
     * @var string
     */
    public $scheduleDateEnd;

    /**
     * @description 查询日期开始时间（yyyy-MM-dd)）
     *
     * @var string
     */
    public $scheduleDateStart;

    /**
     * @description 用户id列表
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'bizInstanceId'     => 'bizInstanceId',
        'maxResults'        => 'maxResults',
        'nextToken'         => 'nextToken',
        'scheduleDateEnd'   => 'scheduleDateEnd',
        'scheduleDateStart' => 'scheduleDateStart',
        'userIdList'        => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizInstanceId) {
            $res['bizInstanceId'] = $this->bizInstanceId;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->scheduleDateEnd) {
            $res['scheduleDateEnd'] = $this->scheduleDateEnd;
        }
        if (null !== $this->scheduleDateStart) {
            $res['scheduleDateStart'] = $this->scheduleDateStart;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListPunchScheduleByConditionWithPagingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizInstanceId'])) {
            $model->bizInstanceId = $map['bizInstanceId'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['scheduleDateEnd'])) {
            $model->scheduleDateEnd = $map['scheduleDateEnd'];
        }
        if (isset($map['scheduleDateStart'])) {
            $model->scheduleDateStart = $map['scheduleDateStart'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
