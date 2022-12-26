<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCardVisitorStatisticDataResponseBody extends Model
{
    /**
     * @description 发送名片数
     *
     * @var int
     */
    public $cardSendCnt;

    /**
     * @description 今日访客增加数
     *
     * @var int
     */
    public $todayVisitAddCnt;

    /**
     * @description 今日访客数
     *
     * @var int
     */
    public $todayVisitCnt;

    /**
     * @description 总访客新增数
     *
     * @var int
     */
    public $totalVisitAddCnt;

    /**
     * @description 总访客数
     *
     * @var int
     */
    public $totalVisitCnt;

    /**
     * @description 微信今日访客新增数
     *
     * @var int
     */
    public $wechatTodayVisitAddCnt;

    /**
     * @description 微信今日访客数
     *
     * @var int
     */
    public $wechatTodayVisitCnt;

    /**
     * @description 微信今日访客增加数
     *
     * @var int
     */
    public $wechatTotalVisitAddCnt;

    /**
     * @description 微信访客数
     *
     * @var int
     */
    public $wechatTotalVisitCnt;
    protected $_name = [
        'cardSendCnt'            => 'cardSendCnt',
        'todayVisitAddCnt'       => 'todayVisitAddCnt',
        'todayVisitCnt'          => 'todayVisitCnt',
        'totalVisitAddCnt'       => 'totalVisitAddCnt',
        'totalVisitCnt'          => 'totalVisitCnt',
        'wechatTodayVisitAddCnt' => 'wechatTodayVisitAddCnt',
        'wechatTodayVisitCnt'    => 'wechatTodayVisitCnt',
        'wechatTotalVisitAddCnt' => 'wechatTotalVisitAddCnt',
        'wechatTotalVisitCnt'    => 'wechatTotalVisitCnt',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardSendCnt) {
            $res['cardSendCnt'] = $this->cardSendCnt;
        }
        if (null !== $this->todayVisitAddCnt) {
            $res['todayVisitAddCnt'] = $this->todayVisitAddCnt;
        }
        if (null !== $this->todayVisitCnt) {
            $res['todayVisitCnt'] = $this->todayVisitCnt;
        }
        if (null !== $this->totalVisitAddCnt) {
            $res['totalVisitAddCnt'] = $this->totalVisitAddCnt;
        }
        if (null !== $this->totalVisitCnt) {
            $res['totalVisitCnt'] = $this->totalVisitCnt;
        }
        if (null !== $this->wechatTodayVisitAddCnt) {
            $res['wechatTodayVisitAddCnt'] = $this->wechatTodayVisitAddCnt;
        }
        if (null !== $this->wechatTodayVisitCnt) {
            $res['wechatTodayVisitCnt'] = $this->wechatTodayVisitCnt;
        }
        if (null !== $this->wechatTotalVisitAddCnt) {
            $res['wechatTotalVisitAddCnt'] = $this->wechatTotalVisitAddCnt;
        }
        if (null !== $this->wechatTotalVisitCnt) {
            $res['wechatTotalVisitCnt'] = $this->wechatTotalVisitCnt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCardVisitorStatisticDataResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardSendCnt'])) {
            $model->cardSendCnt = $map['cardSendCnt'];
        }
        if (isset($map['todayVisitAddCnt'])) {
            $model->todayVisitAddCnt = $map['todayVisitAddCnt'];
        }
        if (isset($map['todayVisitCnt'])) {
            $model->todayVisitCnt = $map['todayVisitCnt'];
        }
        if (isset($map['totalVisitAddCnt'])) {
            $model->totalVisitAddCnt = $map['totalVisitAddCnt'];
        }
        if (isset($map['totalVisitCnt'])) {
            $model->totalVisitCnt = $map['totalVisitCnt'];
        }
        if (isset($map['wechatTodayVisitAddCnt'])) {
            $model->wechatTodayVisitAddCnt = $map['wechatTodayVisitAddCnt'];
        }
        if (isset($map['wechatTodayVisitCnt'])) {
            $model->wechatTodayVisitCnt = $map['wechatTodayVisitCnt'];
        }
        if (isset($map['wechatTotalVisitAddCnt'])) {
            $model->wechatTotalVisitAddCnt = $map['wechatTotalVisitAddCnt'];
        }
        if (isset($map['wechatTotalVisitCnt'])) {
            $model->wechatTotalVisitCnt = $map['wechatTotalVisitCnt'];
        }

        return $model;
    }
}
