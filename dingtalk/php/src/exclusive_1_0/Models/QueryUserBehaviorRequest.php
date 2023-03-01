<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserBehaviorRequest extends Model
{
    /**
     * @description 结束时间(默认当前时间)
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 起始页(默认从1开始)
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 页大小(最大100)
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 端类型((0-全部，1-iOS，2-Android, 3-Mac, 4-Windows))
     *
     * @var int
     */
    public $platform;

    /**
     * @description 开始时间(默认当前时间前7天)
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 用户行为((0-全部，1-截屏，2-录屏))
     *
     * @var int
     */
    public $type;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'endTime'    => 'endTime',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
        'platform'   => 'platform',
        'startTime'  => 'startTime',
        'type'       => 'type',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserBehaviorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['platform'])) {
            $model->platform = $map['platform'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
