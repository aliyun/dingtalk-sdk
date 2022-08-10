<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateLiveRequest extends Model
{
    /**
     * @description 直播封面
     *
     * @var string
     */
    public $coverUrl;

    /**
     * @description 简介
     *
     * @var string
     */
    public $introduction;

    /**
     * @description 预计结束时间
     *
     * @var int
     */
    public $preEndTime;

    /**
     * @description 预计开播时间
     *
     * @var int
     */
    public $preStartTime;

    /**
     * @description 标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 用户id（主播id）
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'coverUrl'     => 'coverUrl',
        'introduction' => 'introduction',
        'preEndTime'   => 'preEndTime',
        'preStartTime' => 'preStartTime',
        'title'        => 'title',
        'unionId'      => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->coverUrl) {
            $res['coverUrl'] = $this->coverUrl;
        }
        if (null !== $this->introduction) {
            $res['introduction'] = $this->introduction;
        }
        if (null !== $this->preEndTime) {
            $res['preEndTime'] = $this->preEndTime;
        }
        if (null !== $this->preStartTime) {
            $res['preStartTime'] = $this->preStartTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateLiveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['coverUrl'])) {
            $model->coverUrl = $map['coverUrl'];
        }
        if (isset($map['introduction'])) {
            $model->introduction = $map['introduction'];
        }
        if (isset($map['preEndTime'])) {
            $model->preEndTime = $map['preEndTime'];
        }
        if (isset($map['preStartTime'])) {
            $model->preStartTime = $map['preStartTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
