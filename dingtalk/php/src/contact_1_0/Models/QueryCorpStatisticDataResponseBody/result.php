<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models\QueryCorpStatisticDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 被收下名片数
     *
     * @var int
     */
    public $cardBeReceivedTotalCnt;

    /**
     * @description 收下名片数
     *
     * @var int
     */
    public $cardReceiveTotalCnt;

    /**
     * @description 被访问数
     *
     * @var int
     */
    public $cardTotalBeVisitedCnt;

    /**
     * @description 日期
     *
     * @var string
     */
    public $dataDate;

    /**
     * @description 钉钉发送数
     *
     * @var int
     */
    public $dingTotalShareCnt;

    /**
     * @description 总发送数
     *
     * @var int
     */
    public $totalSendCnt;

    /**
     * @description 微信发送数
     *
     * @var int
     */
    public $wechatTotalShareCnt;
    protected $_name = [
        'cardBeReceivedTotalCnt' => 'cardBeReceivedTotalCnt',
        'cardReceiveTotalCnt'    => 'cardReceiveTotalCnt',
        'cardTotalBeVisitedCnt'  => 'cardTotalBeVisitedCnt',
        'dataDate'               => 'dataDate',
        'dingTotalShareCnt'      => 'dingTotalShareCnt',
        'totalSendCnt'           => 'totalSendCnt',
        'wechatTotalShareCnt'    => 'wechatTotalShareCnt',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBeReceivedTotalCnt) {
            $res['cardBeReceivedTotalCnt'] = $this->cardBeReceivedTotalCnt;
        }
        if (null !== $this->cardReceiveTotalCnt) {
            $res['cardReceiveTotalCnt'] = $this->cardReceiveTotalCnt;
        }
        if (null !== $this->cardTotalBeVisitedCnt) {
            $res['cardTotalBeVisitedCnt'] = $this->cardTotalBeVisitedCnt;
        }
        if (null !== $this->dataDate) {
            $res['dataDate'] = $this->dataDate;
        }
        if (null !== $this->dingTotalShareCnt) {
            $res['dingTotalShareCnt'] = $this->dingTotalShareCnt;
        }
        if (null !== $this->totalSendCnt) {
            $res['totalSendCnt'] = $this->totalSendCnt;
        }
        if (null !== $this->wechatTotalShareCnt) {
            $res['wechatTotalShareCnt'] = $this->wechatTotalShareCnt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBeReceivedTotalCnt'])) {
            $model->cardBeReceivedTotalCnt = $map['cardBeReceivedTotalCnt'];
        }
        if (isset($map['cardReceiveTotalCnt'])) {
            $model->cardReceiveTotalCnt = $map['cardReceiveTotalCnt'];
        }
        if (isset($map['cardTotalBeVisitedCnt'])) {
            $model->cardTotalBeVisitedCnt = $map['cardTotalBeVisitedCnt'];
        }
        if (isset($map['dataDate'])) {
            $model->dataDate = $map['dataDate'];
        }
        if (isset($map['dingTotalShareCnt'])) {
            $model->dingTotalShareCnt = $map['dingTotalShareCnt'];
        }
        if (isset($map['totalSendCnt'])) {
            $model->totalSendCnt = $map['totalSendCnt'];
        }
        if (isset($map['wechatTotalShareCnt'])) {
            $model->wechatTotalShareCnt = $map['wechatTotalShareCnt'];
        }

        return $model;
    }
}
